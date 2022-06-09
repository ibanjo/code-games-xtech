import { SearchResultDto } from './../../api/xvision-dto';
import { Component, OnInit, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs';
import { XVisionApiService } from 'src/app/api/xvision-api.service';
import { Router } from '@angular/router';
import { delay } from 'rxjs/operators';

@Component({
  selector: 'app-search-result',
  templateUrl: './search-result.component.html',
  styleUrls: ['./search-result.component.scss']
})
export class SearchResultComponent implements OnInit, OnDestroy {

  constructor(private api: XVisionApiService, private router: Router) { }

  isLoading = true;

  searchResults: SearchResultDto[] = [];

  private _subs = new Subscription();

  ngOnInit(): void {
    const searchDto = window?.history?.state?.searchDto;
    this._subs.add(
      this.api.getSuggestions(searchDto).subscribe(values => {
        const newVals = values.users.map(user => ({
          id: user.personId,
          name: user.name,
          surname: user.surnamme,
          city: user.site.description,
          remote: user.remote,
          yearsOfExperience: user.yearsOfExperience,
          position: user.position,
          skills: user.skills.skills.map((s: any) => ({
            feBeDevops: s.FEBEDevops,
            webMobile: s.webMobile,
            technology: s.technology,
            projectRef: s.projectRef,
            description: s.description,
            level: 2
          })),
          languages: [],
          liked: false
        }));
        this.isLoading = false;
        this.searchResults = newVals;
      })
    );
  }

  ngOnDestroy(): void {
    this._subs.unsubscribe();
  }

  addLike(index: number) {
    this.searchResults[index].liked = !this.searchResults[index].liked;
    //TODO: call API
  }

}
