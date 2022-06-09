import { Component, OnInit, OnDestroy } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { XVisionApiService } from 'src/app/api/xvision-api.service';
import { Area, MacroArea, SearchDto, Technology } from 'src/app/api/xvision-dto';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.scss']
})
export class SearchComponent implements OnInit, OnDestroy {

  form!: FormGroup;

  skillsList: MacroArea[] = [];

  areaList: Area[] = [];

  techList: Technology[] = [];

  skillLevels$ = this.api.getSkillLevels();
  languages$ = this.api.getLanguages();
  languagesLevel$ = this.api.getLanguagesLevel();

  private _subs = new Subscription();

  constructor(private fb: FormBuilder, private api: XVisionApiService, private router: Router) { }

  ngOnInit(): void {
    this._createFormGroup();
    this._addSubscriptions();
  }

  ngOnDestroy() {
    this._subs.unsubscribe();
  }

  goBack() {
    this.router.navigate(['home']);
  }

  apply() {
    if (this.form.valid) {
      this.router.navigate(['search-result'], {
        state: {
          searchDto: this.form.getRawValue()
        }
      });
    } else {
      this.form.markAllAsTouched();
    }
  }

  private _createFormGroup() {
    this.form = this.fb.group({
      FEBEDevops: [null, [Validators.required]],
      webMobile: [null, [Validators.required]],
      technology: [null, [Validators.required]],
      level: [],
      languageID: [],
      languageLevel: []
    });
  }



  private _addSubscriptions() {
    this._subs.add(
      this.api.getSkills().subscribe(skills => this.skillsList = skills)
    );
    this._subs.add(
      this.form.valueChanges.subscribe((value: SearchDto) => {
        this.areaList = this.skillsList.find(s => s.description === value.FEBEDevops)?.areas ?? [];
        this.techList = this.skillsList.find(s => s.description === value.FEBEDevops)?.areas.find(a => a.description === value.webMobile)?.technologies ?? [];
      }
    ));
  }

}
