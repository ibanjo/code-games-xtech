import { Get, Post, Body, Controller, HttpCode, ParseUUIDPipe, Param, Query } from '@nestjs/common';
import { UserService } from './user.service';
import { UserDto, UserListDto } from './dto/user.dto';
import { CreateUserDto } from './dto/create-user.dto';
import { GetSimilaritiesRequestDto } from './dto/get-similarities-request.dto';

@Controller('users')
export class UserController {
    constructor(private readonly userService: UserService) { }

    @Get()
    async findAll(@Query() query) : Promise<UserListDto> {
        return await this.userService.findAll(query);
    }

    @Post('get-similarities')
    async getSimilarities(@Body() request: GetSimilaritiesRequestDto) : Promise<UserListDto> {
        return await this.userService.getSimilarities(request);
    }

    @Get(':id')
    async findUser(@Param('id', ParseUUIDPipe) id: string): Promise<UserDto> {
        return await this.userService.findById(id);
    }

    @Post('create-user')
    @HttpCode(204)
    async create(@Body() userData: CreateUserDto): Promise<UserDto> {
        var result = await this.userService.create(userData);
        console.log(result);
        return result;
    }
}
