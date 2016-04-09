declare namespace FuseJS {
	
	module lifecycle {
		function open() : void;
	}

	declare module "FuseJS/Lifecycle" {
		export = lifecycle;
	}
}