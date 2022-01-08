import 'package:flutter/material.dart';
import 'package:flutter_project/2-app/views/stylePages/appColors.dart';
import 'package:responsive_sizer/responsive_sizer.dart';
import 'textWidget.dart';

class MenuOptionsWidget extends StatelessWidget {
  final String text;
  final Icon icon;
  final double? widthButton;
  final FontWeight? fontWeight;
  final Color? textColor;
  final List<Color>? colors;
  final Function()? onPressed;

  const MenuOptionsWidget(
      { Key? key,
        required this.text,
        required this.icon,
        this.widthButton,
        this.fontWeight,
        this.textColor,
        this.colors,
        this.onPressed,
      }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: onPressed,
      child: Container(
        height: 12.h,
        width: 13.h,
        color: AppColors().transparentColor,
        child: Column(
          children: [
            Center(child: icon),
            Center(
              child: Padding(
                padding: EdgeInsets.only(top: 1.h),
                child: TextWidget(
                  text,
                  textColor: textColor ?? AppColors().blackColor91Percent,
                  fontSize: 16.sp,
                  fontWeight: FontWeight.bold,
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }
}