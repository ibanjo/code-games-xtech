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
