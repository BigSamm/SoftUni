const Anime = require('../models/Anime');

module.exports = {
	index: (req, res) => {
        Anime.find().then(animes => {
        	res.render('anime/index', {animes: animes})
		});
	},
	createGet: (req, res) => {
        res.render('anime/create');
	},
	createPost: (req, res) => {
        let animeArguments = req.body;

        Anime.create(animeArguments).then(anime => {
        	res.redirect('/');
		});
	},
	deleteGet: (req, res) => {
        let animeId = req.params.id;

        Anime.findById(animeId).then(anime => {
        	res.render('anime/delete', anime);
		});
	},
	deletePost: (req, res) => {
        let animeId = req.params.id;

        Anime.findByIdAndRemove(animeId).then(anime => {
            res.redirect('/');
        });
	}
};