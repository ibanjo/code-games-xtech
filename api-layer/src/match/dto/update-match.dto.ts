import { IsUUID } from "class-validator";

export class UpdateMatchDto {
    readonly matchAccepted: boolean;
}