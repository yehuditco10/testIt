import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {

  constructor(private http: HttpClient) { }

  getCategories() {
    return this.http.get(environment.baseRoute + 'Categories');
  }
  addCategory(id:number,categoryName:string){
    alert(id);
    alert(categoryName);
    //שליחת שתי פרמטרים
    return this.http.get(environment.baseRoute+ "addCategory?id="+id+'&categoryName='+categoryName);
  }
}
