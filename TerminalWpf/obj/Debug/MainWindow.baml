   M S B A M L   `   `   `  ����F  BTerminalWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TerminalWpfTerminalWpf  5   	       TerminalWpf.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TerminalWpf     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  StartWindow��5	   	   $
��1080��6   $
��1920��6+    � WindowState$ 	Maximized=�68    � WindowStyle$
 None=�6P   .��5      � -   5         �Name$ Mainroot��5      ��5   
   �� 5       �� ImageSource$ bg_it_kletka.png��6    j� TileMode$
 Tile=�68    j� Stretch$ Uniform=�6H    j� 
AlignmentY$	 Top=�6Z    j� Viewport$ 1000,1000,600,600�6k   	 j� ViewportUnits$	 Absolute=�6�   .+�5   
   �� $��	Logos.png��6   $
��Left=�6$   $	��300��6?   $	��Top=�6L   $	��300��6d   
 J� Effect
 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$	 100Q�6#      Color$ White��64      ShadowDepth$ 5Q�6B   6T   5      �� 5   
   -   5         ��Name$ Plaska��5      $
��1900��6!   
������ $��Center=�6K   $��Center=�6f    �� Padding$ 40q�6�   $	��550��6�    �� CornerRadius$ 20��6�   $
��1000��6�   
 5        5      $	 100Q�6#   $ White��64   $ 10Q�6B   6U   ._�5       �� .+�5!      �� $	��Top=�6   $��Center=�64   $%��Терминал отзывов��6Q   $��70(�6k   $��0 0 0 20q�6y   ���	#FF272B3D$��Yu Gothic UI Light)�6�   $
��Bold"�6�   � 5#      $��0 0 0 20q�6   .+�5$      �� -   5        $
��Left=�5$      $��Center=�68   $��Негативный��6S   $��50,350,1115,-530q�6   $	��205��6�   $	��605��6�   ���	#FF9EB8C6$��50(�6�   ���	#FF272B3D$
��Bold"�6�   $��Yu Gothic UI Light)�6   ���	#FF272B3D6   �� 5%      -   5        $��Right=�5%      $��Center=�69   $��Позитивный��6T   $��0,350,50,-528q�6�   $	��205��6�   $	��605��6�   ���	#FF9EB8C6$��50(�6�   ���	#FF272B3D$��Yu Gothic UI Light)�6�   $��Normal"�6  ���	#FF272B3D6   5'      �� 5(      $	��Top=�6   $��Center=�64   $��60(�6S   $��Medium"�6a   $��
0 150 0 20q�6u   ���	#FF272B3D$��Yu Gothic UI Light)�6�   �� 6�   $�В��6�   �� 6�   $�а��6�   �� 6�   $�ш��6�   �� 6�   $�
 опыт ��6�   �� 6  $�был ��6  5)      �� 5*      $	��Top=�6   $��Center=�64   $��ИЛИ��6Q   $��70(�6^   $��Medium"�6l   $��	0 120 0 0q�6�   $��Yu Gothic UI Light)�6�   ���	#FF272B3D6�   5,      5.      54      55      