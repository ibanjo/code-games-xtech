import axios, { AxiosError } from 'axios';
import type { AxiosInstance, AxiosRequestConfig, AxiosResponse, CancelToken } from 'axios';
import { Injectable } from '@nestjs/common';
import { ConfigService } from '@nestjs/config';
import { DataLayerClientBase } from './data-layer-base';

@Injectable()
export class DataLayerClient extends DataLayerClientBase {    
    constructor(configService: ConfigService) {        
        const instance = axios.create();
        const baseUrl = configService.get<string>('DATA_LAYER');
        super(baseUrl, instance);
    }
}