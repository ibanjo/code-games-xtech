import { Area, Technology } from './../../api/xvision-dto';
import { XVisionApiService } from './../../api/xvision-api.service';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { forkJoin, Subscription } from 'rxjs';
import { Language, LanguageLevel, MacroArea, Site } from 'src/app/api/xvision-dto';

@Component({
  selector: 'app-skill-page',
  templateUrl: './skill-page.component.html',
  styleUrls: ['./skill-page.component.scss']
})
export class SkillPageComponent implements OnInit, OnDestroy {

  form!: FormGroup;

  skillsList: MacroArea[] = [];

  areaList: Area[] = [];

  techList: Technology[] = [];

  languages$ = this.api.getLanguages();
  languagesLevel$ = this.api.getLanguagesLevel();
  sites$ = this.api.getSites();

  private _subs = new Subscription();

  constructor(private fb: FormBuilder, private api: XVisionApiService) { }

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
      languageID: [],
      levelID: [],
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
      feBeDevops: [],
      webMobile: [],
      technology: [],
      projectRef: [],
      description: [],
      levelID: []
    });

    this.formSkills.push(skill);
  }

  deleteSkill(index: number) {
    this.formSkills.removeAt(index);
  }

  submit() {
    console.log('FORM', this.form.getRawValue());
  }

  private _createFormGroup() {
    this.form = this.fb.group({
      isRecruiter: [],
      code: [],
      name: [],
      surname: [],
      siteID: [''],
      remote: [false],
      yearsOfExperience: [null, [Validators.required]],
      position: ['', [Validators.required]],
      languages: this.fb.array([
        this.fb.group({
          languageID: [],
          levelID: [],
          preferred: []
        })
      ]),
      skills: this.fb.array([
        this.fb.group({
          feBeDevops: [],
          webMobile: [],
          technology: [],
          projectRef: [],
          description: [],
          levelID: []
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
    //TODO: capire come disabilitare elementi nel selettore
  }

}
