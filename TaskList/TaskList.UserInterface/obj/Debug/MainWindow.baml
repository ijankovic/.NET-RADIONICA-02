   M S B A M L   `   `   `  ����Q  MTaskList.UserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:TaskList.UserInterface.ViewModels!TaskList.UserInterface.ViewModels  5   	   U/clr-namespace:TaskList.UserInterface.Converters!TaskList.UserInterface.Converters  5   	   '    !TaskList.UserInterface.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   F
viewModels/clr-namespace:TaskList.UserInterface.ViewModels     5   	   F
converters/clr-namespace:TaskList.UserInterface.Converters     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   
������� � DataContext 5      9   3TaskList.UserInterface.ViewModels.TaskListViewModel  5   
    � 	Resources 5      4   .TaskList.UserInterface.Converters.BoolInverter   BoolInverter6   0TaskList.UserInterface.Converters.BoolToFinished  BoolToFinished��%:   &	        &	        5   
   6"     5   
   6$   5      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5!   
   �� $��0��6   $��0��6!   $��Users��61     HeaderStyle#��[ 6>   �� 5'   
   $��0��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Center=�6K   .+�5(      �� $��Tasks: ��6   #��[ 6(   �� 5)      #��[ 6;   ��6   �� *SelectedUser.Name+6;   5*      �� 50   
   $��1��6   $��0��6    ��60   �� *Users+ �� SelectedItem 6N   �� *SelectedUser+��56      �� 57      .R�58      �� ��6    �� *Name+59      5;      �� 5>   
   $��1��6   $��1��6$   .��5@      �� ��6   �� *	TasksView+��5A      �� 5B      .R�5C      � $��10q�6    5D      �� 5E   "   $��20 �63   �� 5F   "   $��40 �63   �� 5G   "   $��* �63   �� 5H   "   $	��100 �63   .+�5J      �� $��0��6<   ��6(   �� *Id+6<   �� 5K      $��1��6D   ��6(   �� *
Owner.Name+6D   �� 5L      $��2��6E   ��6(   �� *Description+6E   �� 5R      -   5        $��3��5R   %   ��5S   %   �� *
IsFinished+ �� 	Converter# [ {�5T   %   �� *
IsFinished+# [  5U   %   5V      5W      5Y      5Z      � 5]   
   $��2��6   $��0��6   $��10q�6,   $��2��68    5^      �� 5_      $��* �6#   �� 5`      $	��100 �6#   .+�5g      �� $��0��6_   ��6   �� *NewTaskDescription+ �� UpdateSourceTrigger$ PropertyChanged=�6_   �� 5h      -   5        $��1��5h      $��Add Task��5i      {�5j      �� *
CanAddTask+5k      5l      5n      5o      