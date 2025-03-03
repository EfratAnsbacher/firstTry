import { Component, inject, OnInit, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { category } from '../../models/category.model';
import { CategoriesService } from '../../services/categories.service';
import { TableModule } from 'primeng/table';
import { InputIcon } from 'primeng/inputicon';
import { IconField } from 'primeng/iconfield';
import { ConfirmationService, MessageService } from 'primeng/api';
import { Dialog } from 'primeng/dialog';
import { Ripple } from 'primeng/ripple';
import { ButtonModule } from 'primeng/button';
import { ToastModule } from 'primeng/toast';
import { ToolbarModule } from 'primeng/toolbar';
import { ConfirmDialog } from 'primeng/confirmdialog';
import { InputTextModule } from 'primeng/inputtext';
import { TextareaModule } from 'primeng/textarea';
import { FileUpload } from 'primeng/fileupload';
import { SelectModule } from 'primeng/select';
import { Tag } from 'primeng/tag';
import { RadioButton } from 'primeng/radiobutton';
import { Rating } from 'primeng/rating';
import { InputNumber } from 'primeng/inputnumber';
import { IconFieldModule } from 'primeng/iconfield';
import { InputIconModule } from 'primeng/inputicon';
import { Table } from 'primeng/table';
import { DropdownModule } from 'primeng/dropdown';

interface Column {
  field: string;
  header: string;
  customExportHeader?: string;
}

interface ExportColumn {
  title: string;
  dataKey: string;
}

@Component({
  selector: 'app-categories',
  standalone: true,
  imports: [CommonModule, FormsModule, TableModule, Dialog, Ripple, SelectModule, ToastModule, ToolbarModule, ConfirmDialog, InputTextModule, TextareaModule, CommonModule, FileUpload, DropdownModule, Tag, RadioButton, Rating, InputTextModule, FormsModule, InputNumber, IconFieldModule, InputIconModule],
  templateUrl: './categories.component.html',
  styleUrl: './categories.component.css'
})
export class CategoriesComponent {
  categorySrv: CategoriesService = inject(CategoriesService);

  categoriesList$ = this.categorySrv.getAll();
  //primeNg
//   selectedGifts: gift[] | null = []

//   giftDialog: boolean = false;

//   gifts!: gift[];

//   gift!: gift;

//   submitted: boolean = false;

//   statuses!: any[];

//   @ViewChild('dt') dt!: Table;

//   cols: Column[] =[
//     { field: 'id', header: 'Code', customExportHeader: 'Gift Code' },
//     { field: 'title', header: 'Title' },
//     { field: 'description', header: 'Description' },
//     { field: 'donorId', header: 'Donor' },
//     { field: 'categoryId', header: 'Category' },
//     { field: 'price', header: 'Price' },
//     { field: 'numOfBuyers', header: 'Num Of Buyers' },
//     { field: 'image', header: 'Image' }
//   ];
// ;

//   exportColumns!: ExportColumn[];


//   constructor(
//     // private productService: ProductService,
//     private messageService: MessageService,
//     private confirmationService: ConfirmationService,
//     // private cd: ChangeDetectorRef
    
//   ) { }

//   exportCSV() {
//     this.dt.exportCSV();
//   }

//   // loadDemoData() {
//   //   this.productService.getProducts().then((data) => {
//   //     this.products = data;
//   //     this.cd.markForCheck();
//   //   });

//   //   this.statuses = [
//   //     { label: 'INSTOCK', value: 'instock' },
//   //     { label: 'LOWSTOCK', value: 'lowstock' },
//   //     { label: 'OUTOFSTOCK', value: 'outofstock' }
//   //   ];

    
//   //   this.exportColumns = this.cols.map((col) => ({ title: col.header, dataKey: col.field }));
//   // }

//   // openNew() {
//   //   this.gift = {};
//   //   this.submitted = false;
//   //   this.giftDialog = true;
//   // }

//   editProduct(gift: gift) {
//     this.gift = { ...gift };
//     this.giftDialog = true;
//   }

//   deleteSelectedProducts() {
//     this.confirmationService.confirm({
//       message: 'Are you sure you want to delete the selected gifts?',
//       header: 'Confirm',
//       icon: 'pi pi-exclamation-triangle',
//       accept: () => {
//         this.gifts = this.gifts.filter((val) => !this.selectedGifts?.includes(val));
//         this.selectedGifts = null;
//         this.messageService.add({
//           severity: 'success',
//           summary: 'Successful',
//           detail: 'Gifts Deleted',
//           life: 3000
//         });
//       }
//     });
//   }

//   hideDialog() {
//     this.giftDialog = false;
//     this.submitted = false;
//   }

//   // deleteProduct(gift: gift) {
//   //   this.confirmationService.confirm({
//   //     message: 'Are you sure you want to delete ' + gift.title + '?',
//   //     header: 'Confirm',
//   //     icon: 'pi pi-exclamation-triangle',
//   //     accept: () => {
//   //       this.gifts = this.gifts.filter((val) => val.id !== gift.id);
//   //       this.gift = {};
//   //       this.messageService.add({
//   //         severity: 'success',
//   //         summary: 'Successful',
//   //         detail: 'Gift Deleted',
//   //         life: 3000
//   //       });
//   //     }
//   //   });
//   // }

//   // findIndexById(id: string): number {
//   //   let index = -1;
//   //   for (let i = 0; i < this.gifts.length; i++) {
//   //     if (this.gifts[i].id === id) {
//   //       index = i;
//   //       break;
//   //     }
//   //   }

//   //   return index;
//   // }

//   // createId(): string {
//   //   let id = '';
//   //   var chars = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789';
//   //   for (var i = 0; i < 5; i++) {
//   //     id += chars.charAt(Math.floor(Math.random() * chars.length));
//   //   }
//   //   return id;
//   // }

//   // getSeverity(status: string) {
//   //   switch (status) {
//   //     case 'INSTOCK':
//   //       return 'success';
//   //     case 'LOWSTOCK':
//   //       return 'warning';
//   //     case 'OUTOFSTOCK':
//   //       return 'danger';
//   //   }
//   // }

//   // saveProduct() {
//   //   this.submitted = true;

//   //   if (this.gift.title?.trim()) {
//   //     if (this.gift.id) {
//   //       this.gifts[this.findIndexById(this.gift.id)] = this.gift;
//   //       this.messageService.add({
//   //         severity: 'success',
//   //         summary: 'Successful',
//   //         detail: 'Gift Updated',
//   //         life: 3000
//   //       });
//   //     } else {
//   //       this.gift.id = this.createId();
//   //       this.gift.image = 'gift-placeholder.svg';
//   //       this.gifts.push(this.gift);
//   //       this.messageService.add({
//   //         severity: 'success',
//   //         summary: 'Successful',
//   //         detail: 'Product Created',
//   //         life: 3000
//   //       });
//   //     }

//   //     this.gifts = [...this.gifts];
//   //     this.giftDialog = false;
//   //     this.gift = {};
//   //   }
//   // }







  add(name: string) {
    if (name)
      this.categorySrv.add({ id: 0, name:name}).subscribe(date => {
        this.categoriesList$ = this.categorySrv.getAll();
      });
  }

  save(item: category) {
    this.categorySrv.update(item).subscribe(data => { });
  }

  delete(id: number) {
    this.categorySrv.delete(id).subscribe(d => {
      this.categoriesList$ = this.categorySrv.getAll();
    });
  }
}
