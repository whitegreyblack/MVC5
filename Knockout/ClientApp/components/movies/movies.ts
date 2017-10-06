import * as ko from 'knockout';
import 'isomorphic-fetch';

interface ReleasedMovie {
    city: string;
    date: string;
    name: string;
    genre: string[];
}

class ReleasedMovieModel {
    public movies = ko.observableArray<ReleasedMovie>();

    constructor() {
        fetch('api/Movies/ReleasedMovies')
            .then(response => response.json() as Promise<ReleasedMovie[]>)
            .then(data => {
                this.movies(data);
            });
    }
}

export default { viewModel: ReleasedMovieModel, template: require('./movies.html') };
