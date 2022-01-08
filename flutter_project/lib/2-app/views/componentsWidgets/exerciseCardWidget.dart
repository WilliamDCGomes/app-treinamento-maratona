import 'package:flutter/material.dart';
import 'package:flutter_project/2-app/views/stylePages/appColors.dart';
import 'package:responsive_sizer/responsive_sizer.dart';
import 'textWidget.dart';

class ExerciseCardWidget extends StatelessWidget {
  final String title;
  final double? widthButton;
  final FontWeight? fontWeight;
  final Color? textColor;
  final List<Color>? colors;
  final Function()? onPressed;

  const ExerciseCardWidget(
      { Key? key,
        required this.title,
        this.widthButton,
        this.fontWeight,
        this.textColor,
        this.colors,
        this.onPressed,
      }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      height: 25.h,
      width: 80.w,
      decoration: BoxDecoration(
        borderRadius: BorderRadius.circular(2.5.h),
        gradient: LinearGradient(
          begin: Alignment.topLeft,
          end: Alignment.bottomRight,
          colors: colors ?? [Color(0XFF484592), Color(0XFF619793)],
        ),
      ),
      child: Padding(
        padding: EdgeInsets.all(1.h),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: [
            TextWidget(
              title,
              textColor: AppColors().whiteColor,
              fontWeight: FontWeight.bold,
              fontSize: 22.sp,
              textAlign: TextAlign.start,
            ),
          ],
        ),
      ),
    );
  }
}