   M S B A M L   `   `   `  ����D  @Lab04_OOP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Lab04_OOP	Lab04_OOP  5   	   7 clr-namespace:Lab04_OOP.CommandsLab04_OOP.Commands  5   	   A%clr-namespace:Lab04_OOP.CustomControlLab04_OOP.CustomControl  5
   
       Lab04_OOP.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Lab04_OOP     5   	   ^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.BootstrapIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag	 cMahApps.Metro.IconPacks.Codicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah
 dMahApps.Metro.IconPacks.Coolicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.FileIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Fontaudio, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Fontisto, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.ForkAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.PixelartIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RadixIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.RemixIcon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai  eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj! fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag" cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af# bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj$ fMahApps.Metro.IconPacks.VaadinIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak% gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah& dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137axIcon-http://metro.mahapps.com/winfx/xaml/iconpacks!    	 
                        ! " # $ % & 5      ocommands clr-namespace:Lab04_OOP.Commands!    	 
                        ! " # $ % & 5   	   sControl%clr-namespace:Lab04_OOP.CustomControl!    	 
                        ! " # $ % & 5
   
   b' ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes ' 5   	     � Icon$K  EC:\Users\yana\OneDrive\Рабочий стол\Lab04_OOP\Img\logo.png��5       � Title$ Visory��5   	   $	��650��6   $
��1000��6%   $	��930��62   $	��580��6A    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$. (commands:AplicationCommand.ChangeCommand��5      6L     5   
   -   5        $. (commands:AplicationCommand.RemoveCommand��5      6L     5   
   -   5        $+ %commands:AplicationCommand.AddCommand��5      6I   .��5      � -   5         �Name$ 	styleGrid��5       � ColumnDefinitions 5   
   �� 5      $	��200��6   $��1* �6.   6;   �� 5      $��4* �6   6,    � RowDefinitions 5   
   �� 5      $��0 �6   �� 5      $��75 �6   �� 5      .+�5"   
   �� -   5         ��Name$ 
stylePanel��5"      $��1��6)   $��0��66   $��2��6F   .+�5#      �� $��0,0,0,29q�6   $��2��6+   .+�5$      "   Lab04_OOP.CustomControl.User  5%      �� 5'      $��Center=�5(      $��Center=�5)      
�������$��42(�5+      $
��Bold"�5,      $��0,20,0,0q�5-      � 5/      $	��570��6   $
��1000��6#    50      �� 51      $
��Auto �6$   �� 52      $	��73* �6$   �� 53      $	��35* �6$   �� 54      $��6* �6$   .+�57      �� $��1��6   $	��Top=�6*   $��	0,136,0,0q�6B   $��84��6U   .+�58      �� -   5         ��Name$ 
Add_Button��5:      $+��%commands:AplicationCommand.AddCommand��58         Add#���   59      $	��170��5;      
���   �5=      �� 5>      -   5        $ Form_Button��5>      $	��170��5?        Form_Button#���  5@      $��0 20 0 0q�5A      
���   �5B   +   5C      �� 5E      $��2��6   $��Center=�6*   $��64��6E   .+�5F      ]� .+�5G      �� -   5        $��English��5G   !   
���   �
	 � Tag$	 en��6G   $	��Top=�6s   
�������6�   �� 5H      -	   5        $��Русский��5H   !   
���   �$	 ru��6G   $��Bottom=�6s   
�������6�   5I      5J      5K      5L      ]� 5N   
   $��1��6   $��1��6!   .+�5O      �� -
   5        
 ��Name$
 	SearchBox��5P      $��20 0 0 0q�5O       
 Search) ' #MaterialDesignThemes.Wpf.HintAssist   Hint# �  5Q      $	��250��5S      $
��Left=�5T      $��Center=�5U      
���   �
�������$��14(�5X      ]� 5Y      $	��297��6   .+�5Z      �� -   5        $	
 Min��5Z   C   $��50��6   $��10 0 0 0q�6%   $��40��67     Min# �  5[      �� 5]      -   5        $	
 Max��5]   D   $��50��6   $��10 0 0 0q�6&   $��40��68     Max# �  5^      �� 5`      -   5        $ Filter_Button��5`   @   $	��100��6   #���  6W   
�������
���   �5a      5c      5d      �� 5g   
   $��1��6   $��2��5h      $	��Top=�5i      .+�5j      �� -   5         ��Name$ styleBox��5j      $
��Left=�5k      $	��Top=�5l      $	��150��5m      $��30 0 0 0q�5n      5o      &   System.Windows.Controls.DataGrid  5r   
   -   5          Name$ ProductsDataGrid��5v        DataGridRowStyle1   RowStyle# �  5s        DataGridCellStyle1   	CellStyle# �  5t        DataGridStyle1#���  5u      $��2��5w      $��1��5x      $��20 20 20 20q�5y         Columns 5{      4  .System.Windows.Controls.DataGridTemplateColumn  5|      -   5        DescriptionColumn��,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 True��5|   D      MinWidth$	 200Q�6V      CellTemplate 5}      �� 5~      .R�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5�   "   �� $��2q�5�   $   
���   � �� Padding$ 2 2 2 2q�5�   $    �� CornerRadius$ 2��5�   $   ._�5�   &   �� $	��150��6,   $	��150��68   $
��Fill=�6E   ��6T   �� *Image+5�   #   5�      5�      5�        5�      -   5        ID_Title_Column��   SortMemberPath$ Title��5�   B   $
 True��6Y      Width5  /System.Windows.Controls.DataGridLengthConverter$ 3* 6k   $	 200Q�6v      MaxWidth$	 600Q�6�      Header 5�      �� 5�      -   5         ��Name$ TextName��5�   $     TextName#���  66    5�      �� 5�      .R�5�      �� $ Vertical=�6)   .+�5�   "   �� $
��Wrap=�6-   $��0 0 0 5q�6X   $��16(�6i   ��6A   �� *Title+6i   �� 5�   "   
����p��6,   �� 5�   "   $
��Wrap=�6-   $��0 10 0 0q�6^   ��6A   �� *Description+6^   5�      5�      5�        5�      -   5        Price_Column��$ Price��5�   ?   $
 True��6V   $ 2* 6h   $ 80Q�6s   $	 160Q�6�    5�      �� 5�       		 Price#��� 	 6$    5�      �� 5�      .R�5�      �� $ Vertical=�6)   .+�5�   "   �� $
��Wrap=�6-   $��0 0 0 5q�6p   $��16(�6�   ��6A   �� *Price+ �� StringFormat$ {0} $��6�   5�      5�      5�        5�      -   5        Type_Column��$
 Type��5�   >   $
 True��6T   $ 2* 6f   $ 80Q�6q   $	 160Q�6�    5�      �� 5�       
 Type#��� 
 6%    5�      �� 5�      .R�5�      �� $ Vertical=�6)   .+�5�   "   �� $
��Wrap=�6-   $��0 0 0 5q�6W   $��16(�6h   ��6A   �� *Type+6h   5�      5�      5�        5�      -   5        Operations_Column��$
 True��5�   E   $
 auto 6W    5�      �� 5�      .R�5�      �� $ 
Horizontal=�6)   $��60��6B   .+�5�   "   �� $.��(commands:AplicationCommand.ChangeCommand��6*     gridEditButton#��[ 6]   .��5�   &   .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ PencilOutline=�6<   5�   #   �� 5�   "   $.��(commands:AplicationCommand.RemoveCommand��6+   $��5 0 0 0q�5�   $     gridRemoveButton#��[ 65   .��5�   &     $ DeleteOutline=�6<   5�   #   5�      5�      5�      5�      5�      5�      