   M S B A M L   `   `   `  ����F  BTerminalWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TerminalWpfTerminalWpf  5   	       TerminalWpf.AdminConsole   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TerminalWpf     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  AdminConsole��5	   	   $
��1080��6   $
��1920��6,    � WindowState$ 	Maximized=�69    � WindowStyle$
 None=�6Q   .��5
      � ��5   
   �� 5       �� ImageSource$ bg_it_kletka.png��6    j� TileMode$
 Tile=�68    j� Stretch$ Uniform=�6H    j� 
AlignmentY$	 Top=�6Z    j� Viewport$ 1000,1000,600,600�6k    j� ViewportUnits$ Absolute=�6�   .+�5   
   �� -   5        	 ��Name$	 Textbox��5      $	��140��6"   $
��1000��62   
�������
 �� Padding$
 20q�6T   $��50,40q�6b    �� CornerRadius$ 20��6q    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6#      Color$ White��63      ShadowDepth$ 5Q�6A   ._�5      �� -   5         ��Name$ closebut��5      $'��!Закрыть программу��6'   $��80��6C   $	��350��6O   $��1374,862,48,10q�6[   $��25(�6s   ���	#FF9EB8C6
���   �$��Yu Gothic UI)�6�   
���   �6�   5      �� 5   
   -   5        $��Отправить��5      $��80��6%   $	��350��61   $��121,208,1441,784q�6=   $��25(�6W   ���	#FF9EB8C6
���   �$��Yu Gothic UI)�6�   
���   �6�   �� 5   
   -   5        $��Отправить��5      $��80��6%   $	��350��61   $��121,802,1441,190q�6=   $��25(�6W   ���	#FF9EB8C6
���   �$��Yu Gothic UI)�6�   
���   �6�   �� 5   
   -   5        $��
Назад��5      $��80��6!   $	��350��6-   $��781,922,781,70q�69   $��25(�6Q   ���	#FF9EB8C6
���   �$��Yu Gothic UI)�6�   
���   �6�   �� 5   
   -   5        $��Отправить��5      $��80��6%   $	��350��61   $��121,500,1441,492q�6=   $��25(�6W   ���	#FF9EB8C6
���   �$��Yu Gothic UI)�6�   
���   �6�   �� 5   
   $.��(Отчетность за Сегодня��6   $
��Left=�60   $��40(�6K   $��Yu Gothic UI)�6Y   $��
80,100,0,0q�6t   $	��Top=�6�   $��66��6�   $	��426��6�   �� 5   
   $,��&Отчетность за Неделю��6   $
��Left=�6/   $��40(�6J   $��Yu Gothic UI)�6X   $��
80,400,0,0q�6s   $	��Top=�6�   $��66��6�   $	��426��6�   �� 5   
   $*��$Отчетность за Месяц��6   $
��Left=�6.   $��40(�6I   $��Yu Gothic UI)�6W   $��
80,700,0,0q�6r   $	��Top=�6�   $��66��6�   $	��426��6�   �� 5   
   -   5         ��Name$ lablelalltime��5      $C��=Обращений к термиалу за все время��6(   $
��Left=�6T   $��40(�6o   $��Yu Gothic UI)�6}   $��660,241,0,0q�6�   $	��Top=�6�   $��66��6�   $
��1060��6�   �� 5   
   -   5        $ lablelallclaim��5      $>��8Количество позитивных отзывов��6(   $
��Left=�6P   $��40(�6k   $��Yu Gothic UI)�6y   $��660,400,0,0q�6�   $	��Top=�6�   $��66��6�   $
��1128��6�   �� 5   
   -	   5        $ lablelallcomment��5      $'��!Колличество жалоб��6*   $
��Left=�6F   $��40(�6a   $��Yu Gothic UI)�6o   $��660,533,0,0q�6�   $	��Top=�6�   $��66��6�   $
��1060��6�   5      5      