declare namespace FuseJS {
	
	interface Observable {
		sprock(): void; 
	}

	interface ObservableFactory {
		(name: string) : Observable;
		(val: number) : Observable;
	}

	declare var observable : ObservableFactory;

}