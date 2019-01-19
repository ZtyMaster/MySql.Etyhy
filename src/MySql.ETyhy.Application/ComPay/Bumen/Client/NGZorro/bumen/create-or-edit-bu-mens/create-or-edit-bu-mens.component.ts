
import { Component, OnInit, Injector, Input, ViewChild, AfterViewInit } from '@angular/core';
import { ModalComponentBase } from '@shared/component-base/modal-component-base';
import { CreateOrUpdateBuMensInput,BuMensEditDto, BuMensServiceProxy } from '@shared/service-proxies/service-proxies';
import { Validators, AbstractControl, FormControl } from '@angular/forms';

@Component({
  selector: 'create-or-edit-bu-mens',
  templateUrl: './create-or-edit-bu-mens.component.html',
  styleUrls:[
	'create-or-edit-bu-mens.component.less'
  ],
})

export class CreateOrEditBuMensComponent
  extends ModalComponentBase
    implements OnInit {
    /**
    * 编辑时DTO的id
    */
    id: any ;

	  entity: BuMensEditDto=new BuMensEditDto();

    /**
    * 初始化的构造函数
    */
    constructor(
		injector: Injector,
		private _buMensService: BuMensServiceProxy
	) {
		super(injector);
    }

    ngOnInit() :void{
		this.init();
    }


    /**
    * 初始化方法
    */
    init(): void {
		this._buMensService.getForEdit(this.id).subscribe(result => {
			this.entity = result.buMens;
		});
    }

    /**
    * 保存方法,提交form表单
    */
    submitForm(): void {
		const input = new CreateOrUpdateBuMensInput();
		input.buMens = this.entity;

		this.saving = true;

		this._buMensService.createOrUpdate(input)
		.finally(() => (this.saving = false))
		.subscribe(() => {
			this.notify.success(this.l('SavedSuccessfully'));
			this.success(true);
		});
    }
}
