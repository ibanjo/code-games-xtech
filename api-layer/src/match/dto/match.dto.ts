export class MatchDto {
    matchId: string;
    researchId: string;
    userId: string;
    matchAccepted: boolean;
}

export interface MatchListDto {
    matches: MatchDto[];
    matchesCount: number;
}