import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Language, LanguageLevel, MacroArea, PersonDto, Profile, Site, SkillLevel } from './xvision-dto';

@Injectable({
  providedIn: 'root',
  useFactory: xvisionApiFactory,
  deps: [HttpClient]
})
export class XVisionApiService {
  constructor(protected http: HttpClient) {}

  //TODO: replace with URL
  login(): Observable<Profile> {
    return this.http.get<any>(`${environment.apiBaseUrl}/login`);
  }

  getLanguages(): Observable<Language[]> {
    return this.http.get<any>(`${environment.apiBaseUrl}/languages`);
  }

  getLanguagesLevel(): Observable<LanguageLevel[]> {
    return this.http.get<any>(`${environment.apiBaseUrl}/languagesLevel`);
  }

  getSites(): Observable<Site[]> {
    return this.http.get<any>(`${environment.apiBaseUrl}/sites`);
  }

  getSkills(): Observable<MacroArea[]> {
    return this.http.get<any>(`${environment.apiBaseUrl}/skills`);
  }

  getSkillLevels(): Observable<SkillLevel[]> {
    return this.http.get<any>(`${environment.apiBaseUrl}/skillLevel`)
  }

  saveSkills(dto: PersonDto): Observable<void> {
    const headers = { 'content-type': 'application/json'}
    const body = JSON.stringify(dto);
    return this.http.post<any>(`${environment.apiBaseUrl}/person`, body, {'headers':headers});
  }

}

export class XVisionFakeApiService extends XVisionApiService {

  login(): Observable<any> {
    return this.http.get<any>(`${environment.apiBaseUrl}/login`);
  }

  getLanguages(): Observable<Language[]> {
    return this.http.get<any>(`${environment.apiBaseUrl}/languages`);
  }

  getLanguagesLevel(): Observable<LanguageLevel[]> {
    return this.http.get<any>(`${environment.apiBaseUrl}/languagesLevel`);
  }

  getSites(): Observable<Site[]> {
    return this.http.get<any>(`${environment.apiBaseUrl}/sites`);
  }

  getSkills(): Observable<MacroArea[]> {
    return this.http.get<any>(`${environment.apiBaseUrl}/skills`);
  }

  getSkillLevels(): Observable<SkillLevel[]> {
    return this.http.get<any>(`${environment.apiBaseUrl}/skillLevel`)
  }

}

function xvisionApiFactory(http: HttpClient) {
  return environment.fakeServer ? new XVisionFakeApiService(http) : new XVisionApiService(http);
}
