import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";

import { Article } from "./article-details/article.model"
import { ArticleListService } from "./article-list.service";
import { Subscription } from "rxjs";

@Component({
    selector: 'articles-list',
    templateUrl: './article-list.component.html',
    styleUrls: ['./article-list.component.css']
})
export class ArticlesListComponent implements OnInit{
    articles: Article[];
    private subscription: Subscription;
    constructor(private route: ActivatedRoute, private service: ArticleListService){
    }

    ngOnInit(){
        this.articles = this.service.getArticles();
    }
}