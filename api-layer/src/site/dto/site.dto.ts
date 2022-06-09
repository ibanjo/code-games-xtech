export interface SiteDto {
    siteId?: string;
    code?: number;
    description?: string;
}

export interface SiteListDto {
    sites: SiteDto[];
    sitesCount: number;
}