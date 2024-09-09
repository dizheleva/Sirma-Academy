function createCatalog(input) {
    let movies = [];

    for (const commandLine of input) {
        if (commandLine.includes('addMovie')) {
            let commandArr = commandLine.split(' ');
            commandArr.shift();
            let movieName = commandArr.join(' ');
            let movie = { name: movieName };

            movies.push(movie);
        } else if (commandLine.includes('directedBy')) {
            let movieInfo = commandLine.split(' directedBy ');
            let movieName = movieInfo[0];
            let directorName = movieInfo[1];

            let movie = movies.find(function (m) {
                return m.name === movieName;
            });

            if (movie) {
                movie.director = directorName;
            }
        } else if (commandLine.includes('onDate')) {
            let movieInfo = commandLine.split(' onDate ');
            let movieName = movieInfo[0];
            let movieDate = movieInfo[1];

            let movie = movies.find(function (m) {
                return m.name === movieName;
            });

            if (movie) {
                movie.date = movieDate;
            }
        }
    }

    return movies;
}

function printMovies(input) {
    let movies = createCatalog(input);
    
    for (const movie of movies) {
        if (movie.name && movie.director && movie.date) {
            let movieJSON = JSON.stringify(movie);
            console.log(movieJSON);
        }
    }
}

printMovies([
    'addMovie Fast and Furious',
    'addMovie Godfather',
    'Inception directedBy Christopher Nolan',
    'Godfather directedBy Francis Ford Coppola',
    'Godfather onDate 29.07.2018',
    'Fast and Furious onDate 30.07.2018',
    'Spinderman 2 onDate 01.08.2018',
    'Fast and Furious directedBy Rob Cohen'
]
);
printMovies([
    'addMovie The Avengers',
    'addMovie Spiderman',
    'The Avengers directedBy Pesho Peshov',
    'The Avengers onDate 30.07.2010',
    'Captain America onDate 30.07.2010',
    'Captain America directedBy Joe Russo',
    'The Avengers directedBy Anthony Russo',
]
);