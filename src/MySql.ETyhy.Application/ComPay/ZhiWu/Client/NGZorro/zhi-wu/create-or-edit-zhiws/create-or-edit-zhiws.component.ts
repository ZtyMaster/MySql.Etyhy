
import { Component, OnInit, Injector, Input, ViewChild, AfterViewInit } from '@angular/core';
import { ModalComponentBase } from '@shared/component-base/modal-component-base';
import { CreateOrUpdateZhiwsInput,ZhiwsEditDto, ZhiwsServiceProxy } from '@shared/service-proxies/service-proxies';
import { Validators, AbstractControl, FormControl } from '@angular/forms';

@Component({
  selector: 'create-or-edit-zhiws',
  templateUrl: './create-or-edit-zhiws.component.html',
  styleUrls:[
	'create-or-edit-zhiws.component.less'
  ],
})

export class CreateOrEditZhiwsComponent
  extends ModalComponentBase
    implements OnInit {
    /**
    * 编辑时DTO的id
    */
    id: any ;

	  entity: ZhiwsEditDto=new ZhiwsEditDto();

    /**
    * 初始化的构造函数
    */
    constructor(
		injector: Injector,
		private _zhiwsService: ZhiwsServiceProxy
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
		this._zhiwsService.getForEdit(this.id).subscribe(result => {
			this.entity = result.zhiws;
		});
    }

    /**
    * 保存方法,提交form表单
    */
    submitForm(): void {
		const input = new CreateOrUpdateZhiwsInput();
		input.zhiws = this.entity;

		this.saving = true;

		this._zhiwsService.createOrUpdate(input)
		.finally(() => (this.saving = false))
		.subscribe(() => {
			this.notify.success(this.l('SavedSuccessfully'));
			this.success(true);
		});
    }
}
