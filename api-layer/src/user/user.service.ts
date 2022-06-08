import { Injectable } from '@nestjs/common';
import { UserDto, UserListDto } from './dto/user.dto';
import { validate } from 'class-validator';
import { instanceToPlain, plainToInstance } from 'class-transformer';
import { HttpException } from '@nestjs/common/exceptions/http.exception';
import { HttpStatus } from '@nestjs/common';
import { CreateUserDto } from './dto/create-user.dto';
import { ResearchService } from 'src/research/research.service';
import { MatchService } from 'src/match/match.service';

@Injectable()
export class UserService {
  constructor(private readonly matchService: MatchService, private readonly researchService: ResearchService) { }

  async findAll(query): Promise<UserListDto> {
    // get matches
    const matches = await this.matchService.findAll({ researchId: query.researchId, includeMatchPending: query.includeMatchPending });
    if (matches.matchesCount === 0) {
      const errors = { Matches: 'no matches' };
      throw new HttpException({ errors }, 404);
    }
    // data access layer
    const users = [
      {
        userId: '1',
        code: 1,
        name: 'Sa',
        surname: 'Fa',
        siteId: '1',
        yearsOfExperience: 4,
        position: 'tech position',
        remote: true,
        isRecruiter: false,
        skills: {
          skills: [],
          skillsCount: 0
        }
      },
      {
        userId: '2',
        code: 2,
        name: 'Sa',
        surname: 'Fa',
        siteId: '1',
        yearsOfExperience: 19,
        position: 'tech position',
        remote: true,
        isRecruiter: false,
        skills: {
          skills: [],
          skillsCount: 0
        }
      }
    ];
    const usersCount = users.length;
    // get research
    const research = await this.researchService.findById(query.researchId);
    
    return { research, users, usersCount };
  }

  async findById(id: string): Promise<UserDto> {
    // get user
    const user = {
      id: 1,
      username: 'Safa',
      email: 'email',
      bio: 'bio',
      image: 'image',
      password: ''
    };
    // throw error if not found
    if (!user) {
      const errors = { User: ' not found' };
      throw new HttpException({ errors }, 404);
    }
    // return user
    return plainToInstance(UserDto, user);
  }

  async create(dto: CreateUserDto): Promise<UserDto> {
    // validate
    const errors = await validate(dto);
    if (errors.length > 0) {
      throw new HttpException({ message: 'Input data validation failed', errors }, HttpStatus.BAD_REQUEST);
    } else {
      // create new user
      let newUser = instanceToPlain(dto);
      // data access layer
      const user = {
        id: 1,
        username: 'Safa',
        email: 'email',
        bio: 'bio',
        image: 'image'
      };
      // return saved user
      return plainToInstance(UserDto, user);
    }
  }
}
