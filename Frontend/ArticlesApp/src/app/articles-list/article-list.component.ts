import { Component, OnInit } from "@angular/core";
import { Article } from "./article-details/article.model"
import { ArticleListService } from "./article-list.service";

@Component({
    selector: 'articles-list',
    templateUrl: './article-list.component.html',
    styleUrls: ['./article-list.component.css']
})
export class ArticlesListComponent implements OnInit{
    articles: Article[];

    constructor(private service: ArticleListService){
    }

    ngOnInit(){
        this.articles = this.service.getArticles();
    }
}