   M S B A M L   `   `   `  ����F  BJenoptikWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:JenoptikWPF.Views.DialogsJenoptikWPF.Views.Dialogs  5   	   O,clr-namespace:JenoptikWPF.Views.UserControlsJenoptikWPF.Views.UserControls  5   	   7 clr-namespace:JenoptikWPF.ModelsJenoptikWPF.Models  5   	   7    1JenoptikWPF.Views.Dialogs.AdvancedSettingsDialogs   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:JenoptikWPF.Views.Dialogs     5   	   EuserControls,clr-namespace:JenoptikWPF.Views.UserControls     5   	   1data clr-namespace:JenoptikWPF.Models     5   	     � Title$  Advanced Parameters��5
   	   $	��604��6%   $	��515��62    � Icon$ /Assets/logo.png��6>   .��5      � ���#EBF1F4 � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��2* �6   6*   .+�5   
   2   ,JenoptikWPF.Views.UserControls.SliderControl  $��0��6%   $
��Left=�62   $��center=�6M   $	��430��6h   $��30,0,0,0q�6t      Header$ Laser Beam Diameter��6�      MinValue$
 10.0Q�5   %      MaxValue$	 500Q�65      Unit$	 µm��6D      Value 5   %   �� *$"LaserParamsModel.LaserBeamDiameter+  5   
   $��1��6%   $
��Left=�62   $��center=�6M   $	��430��6h   $��30,0,0,0q�6u   $ Pulse Frequency��6�   $ 1Q�5   %   $	 100Q�62   $	 KHZ��6A    5   %   �� *!LaserParamsModel.PulseFrequency+4   .JenoptikWPF.Views.UserControls.ComboBoxControl  5   
   $��2��6'   $
��Left=�64   $��center=�6O   $	��430��6j   $��30,0,0,0q�6w      Header$ 
Beam Shape��6�   %   JenoptikWPF.Models.ComboBoxList	   BeamShapeOptions
   Items#
 Z	 5   '      Value 5    '   �� *LaserParamsModel.BeamShape+  5"   
   $��3��6'   $
��Left=�64   $��center=�6O   $	��430��6j   $��30,0,0,0q�6v   $ 
Assist Gaz��6�      AssistGazOptions#
 Z 5#   '    5$   '   �� *LaserParamsModel.AssistGas+�� 5&   
   $��4��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   $��
30,0,30,30q�6W    � 	Resources 5'       �� 
TargetType �� Property �� Value��%�   '��       �� 5(      " ��6   .�5)      ��  � ��$	 100��6.   �� 5*       � ��$ 45��6/   �� 5+       � ��$ 10q�6/   5,      5-      .+�5.      �� ���#CCE2EE���#006EA9.��6?   Abort6F   �� 5/      ���#006EA9
�������.��6>   Save6D   50      54      55      