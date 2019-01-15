const Film = require('../models/Film');

module.exports = {
	index: (req, res) => {
		Film.find().then(films => {
		    res.render('film/index', {films: films})
        })
	},
	createGet: (req, res) => {
	    res.render('film/create');
	},
	createPost: (req, res) => {
        let filmArguments = req.body;

        Film.create(filmArguments).then(film => {
           res.redirect('/');
        });
	},
	editGet: (req, res) => {
	    let filmId = req.params.id;

	    Film.findById(filmId).then(film => {
	       res.render('film/edit', film);
        });
	},
	editPost: (req, res) => {
        let filmId = req.params.id;
        let filmArguments = req.body;

        Film.findByIdAndUpdate(filmId, filmArguments).then(film => {
            res.redirect('/');
        });
	},
	deleteGet: (req, res) => {
        let filmId = req.params.id;

        Film.findById(filmId).then(film => {
            res.render('film/delete', film);
        });
	},
	deletePost: (req, res) => {
        let filmId = req.params.id;

        Film.findByIdAndRemove(filmId).then(film => {
            res.redirect('/');
        });
	}
};