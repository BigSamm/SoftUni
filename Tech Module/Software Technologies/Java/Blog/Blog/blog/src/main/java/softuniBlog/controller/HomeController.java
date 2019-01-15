package softuniBlog.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import softuniBlog.entity.Article;
import softuniBlog.repository.ArticleRepository;

import java.util.HashSet;
import java.util.Set;

@Controller
public class HomeController {

    private final ArticleRepository articleRepository;

    @Autowired
    public HomeController(ArticleRepository articleRepository) {
        this.articleRepository = articleRepository;
    }

    @GetMapping("/")
    public String index(Model model) {

        Set<Article> allArticles = new HashSet<>(this.articleRepository.findAll());
        model.addAttribute("articles", allArticles);
        model.addAttribute("view", "home/index");
        return "base-layout";
    }
}
