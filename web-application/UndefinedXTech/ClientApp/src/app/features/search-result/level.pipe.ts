import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'skillLevel'
})

export class SkillLevelPipe implements PipeTransform {
  transform(value: any, ...args: any[]): any {
    switch (value) {
      case 0:
        return 'Beginner';
      case 1:
        return 'Medium';
      case 2:
        return 'Advanced';
      default:
        return '';
    }
  }
}
