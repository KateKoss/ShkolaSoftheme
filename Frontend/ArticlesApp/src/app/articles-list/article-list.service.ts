// import { Injectable } from "@angular/core";

import { Article } from "./article-details/article.model";

export class ArticleListService{
    articles: Article[] = [{
        id: "1",
        title: "The Day in Question",
        shortDescription: "My first article",
        rubric: "News"
    },
    {
        id: "2",
        title: "My article",
        shortDescription: "My second article",
        rubric: "Science"
    }];
    getArticles() : Article[] {
        return this.articles;
    }
}