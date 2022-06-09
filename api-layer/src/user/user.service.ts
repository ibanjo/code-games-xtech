import { Injectable } from '@nestjs/common';
import { MLUserDto, UserDto, UserListDto } from './dto/user.dto';
import { validate } from 'class-validator';
import { instanceToInstance } from 'class-transformer';
import { HttpException } from '@nestjs/common/exceptions/http.exception';
import { HttpStatus } from '@nestjs/common';
import { CreateUserDto } from './dto/create-user.dto';
import { ResearchService } from 'src/research/research.service';
import { MatchService } from 'src/match/match.service';
import { DataLayerClient } from 'src/adapter/data-layer';
import { MLLayerClient } from 'src/adapter/ml-layer';
import { GetSimilaritiesRequestDto } from './dto/get-similarities-request.dto';
import { SkillService } from 'src/skill/skill.service';
import { CreateResearchDto } from 'src/research/dto/create-research.dto';

@Injectable()
export class UserService {
  constructor(
    private readonly matchService: MatchService,
    private readonly researchService: ResearchService,
    private readonly skillService: SkillService,
    private readonly dataLayer: DataLayerClient,
    private readonly MLLayer: MLLayerClient) { }

  async getSimilarities(dto: GetSimilaritiesRequestDto): Promise<UserListDto> {
    const research = await this.researchService.create(instanceToInstance<CreateResearchDto>(dto));
    let matchResearch = {
      ResearchID: research.researchId,
      LanguageID: dto.languageID,
      LanguageLevel: dto.languageLevel,
      FEBEDevops: dto.FEBEDevops,
      WebMobile: dto.webMobile,
      Technology: dto.technology,
      SkillLevel: dto.level
    };
    //ML layer
    const resultML = await this.MLLayer.postAsync(matchResearch, "/getSimilarities");
    const personIds = Object.values(resultML);
    // data layer
    const allUsers = await this.dataLayer.personAll();
    const usersEntities = allUsers.filter(person => personIds.find(personId => String(personId).toLowerCase() === person.personId.toLowerCase()));
    const users = instanceToInstance<UserDto[]>(usersEntities);
    const usersCount = users.length;
    return { research, users, usersCount };
  }

  async findAll(query): Promise<UserListDto> {
    // get matches
    const matches = await this.matchService.findAll({ researchId: query.researchId, includeMatchPending: query.includeMatchPending });
    if (matches.matchesCount === 0) {
      const errors = { Matches: 'no matches' };
      throw new HttpException({ errors }, 404);
    }

    // get research
    const research = await this.researchService.findById(query.researchId);

    const people = await this.dataLayer.personAll();
    const users = instanceToInstance<UserDto[]>(people);
    const usersCount = users.length;

    return { research, users, usersCount };
  }


  async fetchMLData(): Promise<MLUserDto[]> {
    const people = (await this.dataLayer.personAll()).map(x => x.personId);
    const result = [];
    for (let i = 0; i < people.length; i++) {
      const userSkills = await this.skillService.findByUserId(people[i]);
      result.push({
        personId: people[i],
        skills: userSkills
      });
    }
    return result;
  }

  async findById(id: string): Promise<UserDto> {
    // data access layer
    const user = {
      personId: '1',
      code: 1,
      name: 'Sa',
      surnamme: 'Fa',
      // site: 'city',
      yearsOfExperience: 4,
      position: 'tech position',
      remote: true,
      isRecruiter: false,
      skills: {
        skills: [],
        skillsCount: 0
      },
      languages: {
        languages: [],
        languagesCount: 0
      }
    };
    // throw error if not found
    if (!user) {
      const errors = { User: ' not found' };
      throw new HttpException({ errors }, 404);
    }
    // return user
    return instanceToInstance<UserDto>(user);
  }

  async create(dto: CreateUserDto): Promise<UserDto> {
    // validate
    const errors = await validate(dto);
    if (errors.length > 0) {
      throw new HttpException({ message: 'Input data validation failed', errors }, HttpStatus.BAD_REQUEST);
    } else {
      // create new user
      let userEntity = instanceToInstance(dto);
      // data access layer
      const user = {
        personId: '1',
        code: 1,
        name: 'Sa',
        surnamme: 'Fa',
        // site: 'city',
        yearsOfExperience: 4,
        position: 'tech position',
        remote: true,
        isRecruiter: false,
        skills: {
          skills: [],
          skillsCount: 0
        },
        languages: {
          languages: [],
          languagesCount: 0
        }
      };
      // return saved user
      return instanceToInstance<UserDto>(user);
    }
  }
}
