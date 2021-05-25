# How to bind SchedulerControl to data using Entity Framework

This example illustrates how you bind your Scheduler Control to data from an SQLite database. When you run this project on your side for the first time, the code from the App's constructor should create the database.

To process end-user actions in SchedulerControl and save corresponding changes to the database, you need to process corresponding [SchedulerControl events](https://docs.devexpress.com/Win10Apps/DevExpress.UI.Xaml.Scheduler.SchedulerControl._events). To do this in an MVVM way, you can implement commands in your ViewModel and use our **EventToCommand** class:

````xaml
<dxmvvmi:Interaction.Behaviors>
    <dxmvvm:EventToCommand EventName="AppointmentAdded" 
						   Command="{Binding AppointmentAddedCommand}"
		 				   EventArgsConverter="{local:EventArgsConverter}"   />
	...
</dxmvvmi:Interaction.Behaviors>
````

### There are two cases when specific logic is required: 
1. When an end-user modifies and/or deletes an occurrence. You do not need to delete anything from the database in this case. Instead, you need to add a record about such an exception. In this example, this logic is implemented in *MainViewModel*'s **SaveChanges** and **AppointmentRemoved** methods.
2. When an end-user deletes a recurrent item. At this moment, SchedulerControl deletes all exceptions (modified and deleted occurrences) related to this recurrent item. Therefore, you need to explicitly do the same in the database. You can see the related implementation in the *MainViewModel*'s **SaveChanges** method. 
