import axios, { AxiosError } from 'axios';
import type { AxiosInstance, AxiosRequestConfig, AxiosResponse, CancelToken } from 'axios';
import { Injectable } from '@nestjs/common';
import { ConfigService } from '@nestjs/config';

@Injectable()
export class MLLayerClient {    
    private instance: AxiosInstance;
    constructor(configService: ConfigService) {
        this.instance = axios.create({
            baseURL: configService.get<string>('ML_LAYER')
        });  
    }

    async postAsync(content: any, url: string, cancelToken?: CancelToken | undefined) : Promise<any>  {
        const content_ = JSON.stringify(content);
        let options_: AxiosRequestConfig = {
            data: content_,
            method: "POST",
            url: url,
            headers: {
                "Content-Type": "application/json",
            },
            cancelToken
        };
        
        let result;
        await this.instance.request(options_).catch((_error: any) => {
            if (this.isAxiosError(_error) && _error.response) {
                return _error.response;
            } else {
                throw _error;
            }
        }).then((_response: AxiosResponse) => {
            result = this.processPOST(_response);
        });
        return result;
    }

    private isAxiosError(obj: any | undefined): obj is AxiosError {
        return obj && obj.isAxiosError === true;
    }

    private throwException(message: string, status: number, response: string, headers: { [key: string]: any; }, result?: any): any {
        if (result !== null && result !== undefined)
            throw result;
        else
            throw new ApiException(message, status, response, headers, null);
    }

    protected processPOST(response: AxiosResponse): Promise<any> {
        const status = response.status;
        let _headers: any = {};
        if (response.headers && typeof response.headers === "object") {
            for (let k in response.headers) {
                if (response.headers.hasOwnProperty(k)) {
                    _headers[k] = response.headers[k];
                }
            }
        }
        if (status === 200) {
            const _responseText = response.data;
            return _responseText as any;
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.data;
            return this.throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Promise.resolve<void>(null as any);
    }
}

export class ApiException extends Error {
    override message: string;
    status: number;
    response: string;
    headers: { [key: string]: any; };
    result: any;

    constructor(message: string, status: number, response: string, headers: { [key: string]: any; }, result: any) {
        super();

        this.message = message;
        this.status = status;
        this.response = response;
        this.headers = headers;
        this.result = result;
    }

    protected isApiException = true;

    static isApiException(obj: any): obj is ApiException {
        return obj.isApiException === true;
    }
}