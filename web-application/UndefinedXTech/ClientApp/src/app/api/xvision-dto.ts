export interface Profile {
  id: string;
  name: string;
  surname: string;
  code: string;
  isRecruiter: boolean;
}

export interface Language {
  id: string;
  description: string;
}

export interface LanguageLevel {
  id: string;
  description: string;
}

export interface Site {
  id: string;
  city: string;
}

export interface Technology {
  id: string;
  description: string;
}

export interface Area {
  id: string;
  description: string;
  technologies: Technology[];
}

export interface MacroArea {
  id: string;
  description: string;
  areas: Area[];
}

export interface SkillLevel {
  id: number;
  description: string;
}

export interface SkillDto {
  feBeDevops: string;
  webMobile: string;
  technology: string;
  projectRef?: string;
  description?: string;
  level: number;
}

export interface LanguageDto {
  languageID: string;
  levelID: string;
  preferred: boolean;
}

export interface LanguageSearchDto {
  code: number;
  description: string;
  languageLevelCode: number;
  languageLevelDescription: string;
  preferred: boolean;
}

export interface PersonDto {
  isRecruiter: boolean;
  code: string;
  name: string;
  surname: string;
  siteID: string;
  remote: boolean;
  yearsOfExperience: number;
  position: string;
  languages: LanguageDto[];
  skills: SkillDto[];
}

export interface SearchDto {
  feBeDevops: string;
  webMobile: string;
  technology: string;
  level?: number;
  languageID?: string;
  languageLevel?: string;
}

export interface SearchResultDto {
  id: string;
  name: string;
  surname: string;
  city: string;
  remote: boolean;
  yearsOfExperience: number;
  position: string;
  skills: SkillDto[];
  languages: LanguageSearchDto[];
  liked?: boolean;
}
