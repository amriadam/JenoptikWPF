   M S B A M L   `   `   `  ����F  BJenoptikWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:JenoptikWPF.Views.DialogsJenoptikWPF.Views.Dialogs  5   	   O,clr-namespace:JenoptikWPF.Views.UserControlsJenoptikWPF.Views.UserControls  5   	   8    2JenoptikWPF.Views.Dialogs.LoadMaterialParamsDialog   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:JenoptikWPF.Views.Dialogs     5   	   EuserControls,clr-namespace:JenoptikWPF.Views.UserControls     5   	     � Title$  Load Material Params��5	   	   $	��504��6&   $	��475��63    � Icon$ /Assets/logo.png��6?   .��5
      � ���#EBF1F4 � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��2* �6   6*   .+�5   
   4   .JenoptikWPF.Views.UserControls.ComboBoxControl  $��0��6'   $
��Left=�64   $��center=�6O   $	��400��6j   $��30,0,0,0q�6v      Header$ Material��6�      Items 5   '   �� *MaterialNamesList+2   ,JenoptikWPF.Views.UserControls.SliderControl  5   
   $��1��6%   $
��Left=�62   $��center=�6M   $	��400��6h   $��30,0,0,0q�6u      Header$ Thikness��6�      MinValue$ 1Q�5         MaxValue$ 20Q�6*      Unit$ mm��68   	   Value$	 15Q�5        5   
   $��2��6'   $
��Left=�64   $��center=�6O   $	��400��6j   $��30,0,0,0q�6v   $ 	Operation��6�   �� 5   
   $��4��6   
 �� Orientation$
 
Horizontal=�6"   $��Right=�6;   $��
30,0,30,30q�6W    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5      " ��6   .�5      ��  � ��$	 100��6.   �� 5       � ��$ 45��6/   �� 5        � ��$ 10q�6/   5!      5"      .+�5#      �� ���#CCE2EE���#006EA9.��6?   Abort6F   �� 5$      ���#006EA9
�������.��6>   Save6D   5%      5)      5*      