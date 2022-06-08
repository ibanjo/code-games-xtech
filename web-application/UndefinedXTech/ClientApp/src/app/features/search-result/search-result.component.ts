import { SearchResultDto } from './../../api/xvision-dto';
import { Component, OnInit, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs';
import { XVisionApiService } from 'src/app/api/xvision-api.service';
import { Router } from '@angular/router';

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
        this.isLoading = false;
        this.searchResults = values;
      })
    );
  }

  ngOnDestroy(): void {
    this._subs.unsubscribe();
  }

  back() {
    this.router.navigate(['search']);
  }

  addLike(index: number) {
    this.searchResults[index].liked = !this.searchResults[index].liked;
    //TODO: call API
  }



}
