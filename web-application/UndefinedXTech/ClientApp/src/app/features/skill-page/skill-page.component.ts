import { Area, SkillDto, Technology } from './../../api/xvision-dto';
import { XVisionApiService } from './../../api/xvision-api.service';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { MacroArea } from 'src/app/api/xvision-dto';
import { Router } from '@angular/router';
import { delay } from 'rxjs/operators';
import { AuthService } from 'src/app/core/auth.service';

@Component({
  selector: 'app-skill-page',
  templateUrl: './skill-page.component.html',
  styleUrls: ['./skill-page.component.scss']
})
export class SkillPageComponent implements OnInit, OnDestroy {

  form!: FormGroup;

  skillsList: MacroArea[] = [];

  areaList: Area[][] = [];

  techList: Technology[][] = [];

  loading = false;

  languages$ = this.api.getLanguages();
  languagesLevel$ = this.api.getLanguagesLevel();
  sites$ = this.api.getSites();
  skillLevels$ = this.api.getSkillLevels();

  private _subs = new Subscription();

  constructor(private fb: FormBuilder, private api: XVisionApiService, private router: Router, private auth: AuthService) { }

  ngOnInit() {
    this._createFormGroup();
    this._addSubscriptions();
  }

  ngOnDestroy() {
    this._subs.unsubscribe();
  }

  get formLanguages() {
    return this.form.controls['languages'] as FormArray;
  }

  addLanguage() {
    const language = this.fb.group({
      languageID: [null, [Validators.required]],
      levelID: [null, [Validators.required]],
      preferred: []
    });

    this.formLanguages.push(language);
  }

  deleteLanguage(index: number) {
    this.formLanguages.removeAt(index);
  }

  get formSkills() {
    return this.form.controls['skills'] as FormArray;
  }

  addSkill() {
    const skill = this.fb.group({
      feBeDevops: [null, [Validators.required]],
      webMobile: [null, [Validators.required]],
      technology: [null, [Validators.required]],
      projectRef: [],
      description: [],
      level: [null, [Validators.required]]
    });

    this.formSkills.push(skill);
    this.areaList.push([]);
    this.techList.push([]);
  }

  deleteSkill(index: number) {
    this.formSkills.removeAt(index);
    this.areaList.splice(index, 1);
    this.techList.splice(index, 1);
  }

  submit() {
    console.log('FORM', this.form.getRawValue());
    if (this.form.valid) {
      this.loading = true;
      this._subs.add(
        this.api.saveSkills(this.form.getRawValue()).pipe(delay(500)).subscribe(() =>  this.router.navigate(['home']))
      );
    } else {
      this.form.markAllAsTouched();
    }
  }

  private _createFormGroup() {
    this.form = this.fb.group({
      isRecruiter: [this.auth.data?.isRecruiter],
      code: [this.auth.data?.code],
      name: [this.auth.data?.name],
      surname: [this.auth.data?.surname],
      siteID: [''],
      remote: [false],
      yearsOfExperience: [null, [Validators.required]],
      position: ['', [Validators.required]],
      languages: this.fb.array([
        this.fb.group({
          languageID: [null, [Validators.required]],
          levelID: [null, [Validators.required]],
          preferred: []
        })
      ]),
      skills: this.fb.array([
        this.fb.group({
          feBeDevops: [null, [Validators.required]],
          webMobile: [null, [Validators.required]],
          technology: [null, [Validators.required]],
          projectRef: [],
          description: [],
          level: [null, [Validators.required]]
        })
      ])
    });
  }

  private _addSubscriptions() {
    this._subs.add(
      this.api.getSkills().subscribe(skills => this.skillsList = skills)
    );
    this._subs.add(
      this.form.get('remote')?.valueChanges.subscribe(value => {
        if (value) {
          this.form.get('siteID')?.setValue(null);
        }
      })
    );
    this._subs.add(
      this.formSkills.valueChanges.subscribe((value: SkillDto[]) => value?.forEach((v, index) => {
        this.areaList[index] = this.skillsList.find(s => s.description === v.feBeDevops)?.areas ?? [];
        this.techList[index] = this.skillsList.find(s => s.description === v.feBeDevops)?.areas.find(a => a.description === v.webMobile)?.technologies ?? [];
      }))
    );
  }
}
