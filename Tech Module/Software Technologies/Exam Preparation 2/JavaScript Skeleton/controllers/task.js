const Task = require('../models/Task');

module.exports = {
	index: (req, res) => {
		Task.find().then(tasks => {
			res.render('task/index',
				{
					'openTasks': tasks.filter(t => t.status === 'Open'),
					'inProgressTasks': tasks.filter(t => t.status === 'In Progress'),
					'finishedTasks': tasks.filter(t => t.status === 'Finished'),
				})
		});
	},
	createGet: (req, res) => {
		res.render('task/create');
	},
	createPost: (req, res) => {
		let task = req.body;

		Task.create(task).then(task => {
			res.redirect('/');
		}).catch(err => {
			task.error = 'Cannot create task.';
			res.render('task/create', task);
		});
	},
	editGet: (req, res) => {
		let tasksId = req.params.id;

		Task.findById(tasksId).then(task => {
			if(task)
				return res.render('task/edit', task);
			else
				return res.redirect('/');
		}).catch(err => res.redirect('/'));
	},
	editPost: (req, res) => {
		let taskId = req.params.id;
		let task = req.body;

		Task.findByIdAndUpdate(taskId, task, {RunValidators: true}).then(tasks => {
			res.redirect('/');
		}).catch(err => {
			task.Id = taskId;
			task.error = 'Cannot edit task.';
			return res.render('task/edit', task);
		});
	}
};