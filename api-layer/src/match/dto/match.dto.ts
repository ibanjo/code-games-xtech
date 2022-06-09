export class MatchDto {
    matchId?: string;
    employeeId?: string;
    researchId?: string;
    matchAcceptedByEmployee?: boolean;
}

export interface MatchListDto {
    matches: MatchDto[];
    matchesCount: number;
}