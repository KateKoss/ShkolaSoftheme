import { Article } from "./article-details/article.model";
import { Observable } from "rxjs";

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