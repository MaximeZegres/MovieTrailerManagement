import { Component, OnInit } from '@angular/core';
import { IMovie } from './movie';
import { MovieService } from './movie.service';

@Component({
  selector: 'movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.css']
})
export class MovieListComponent implements OnInit {
  movies: IMovie[] = [];
  errorMessage = '';

  constructor(private movieService: MovieService) {
  }

  ngOnInit() {
    this.movieService.getMovies().subscribe({
      next: movies => this.movies = movies,
      error: err => this.errorMessage = err
    });
  }

}
