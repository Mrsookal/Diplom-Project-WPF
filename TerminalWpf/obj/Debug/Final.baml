   M S B A M L   `   `   `  ����F  BTerminalWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TerminalWpfTerminalWpf  5   	       TerminalWpf.Final   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TerminalWpf     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  StartWindow��5	   	   $
��1080��6   $
��1920��6+    � WindowState$ 	Maximized=�68    � WindowStyle$
 None=�6P    � WindowStartupLocation$ CenterOwner=�6c   .��5      � -   5         �Name$ Mainroot��5      ��5   
   �� 5       �� ImageSource$ bg_it_kletka.png��6    j� TileMode$
 Tile=�68    j� Stretch$ Uniform=�6H    j� 
AlignmentY$	 Top=�6Z   	 j� Viewport$	 1000,1000,600,600�6k   
 j� ViewportUnits$
 Absolute=�6�   .+�5   
   �� $��	Logos.png��6   $	��506��6%   $	��528��63   $��692,30,692,536q�6?    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$	 100Q�6#      Color$ White��64      ShadowDepth$ 5Q�6B   6T   5      �� 5   
   -   5         ��Name$ Textbox��5      $	��140��6"   $
��1000��62   
������� �� Padding$ 20q�6U   $��456,590,456,242q�6c    �� CornerRadius$ 20��6|    5        5      $ 10Q�6#   $ White��63   $ 5Q�6A   ._�5      �� .+�5      �� $0��*Спасибо за ваше мнение!��6   $��Center=�6:   
���   �$��Center=�6j   $��60(�6�   $��Yu Gothic UI)�6�   6�   �� 5      
������ $��30(�61   $�� ��6?   6N   �� 5      -   5         ��Name$ button1��5      ���	#FF9EB8C6$'��!Отменить отправку��6A   
���   ����	#DD000000$��Yu Gothic UI Semibold)�6�   $��25(�6�   $	��400��6�   $��60��6�   $��Normal"�6�   $��280,0q�6�   5       5"      5#      5&      