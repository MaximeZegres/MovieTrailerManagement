import { Injectable } from '@angular/core';
import { IMovie } from './movie';

@Injectable({
    providedIn: 'root'
}
)
export class MovieService {

    getMovies(): IMovie[] {
        return [
            {
                "id": "6aad4a29-118a-465f-8767-233be593bacc",
                "title": "Why Him",
                "releaseDate": "2016-12-23T00:00:00+01:00",
                "urlImdb": "https://www.imdb.com/title/tt4501244/",
                "addedDate": "2019-08-02T00:00:00+02:00"
            },
            {
                "id": "e249e05b-ee59-4d3e-ad1b-a56a02c28cfa",
                "title": "Ashby",
                "releaseDate": "2015-09-25T00:00:00+02:00",
                "urlImdb": "https://www.imdb.com/title/tt3774466/",
                "addedDate": "2019-08-02T00:00:00+02:00"
            },
            {
                "id": "b9d58f45-bf44-4d4d-8279-a6fc6c1984c4",
                "title": "99 Homes",
                "releaseDate": "2014-04-27T00:00:00+02:00",
                "urlImdb": "https://www.imdb.com/title/tt2891174/",
                "addedDate": "2019-08-02T00:00:00+02:00"
            }
        ];
    }

}