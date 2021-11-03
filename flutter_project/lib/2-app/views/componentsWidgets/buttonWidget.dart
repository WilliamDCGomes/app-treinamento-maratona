import 'package:flutter/material.dart';
import 'package:flutter_project/2-app/views/stylePages/appColors.dart';
import 'package:responsive_sizer/responsive_sizer.dart';
import 'textWidget.dart';

class ButtonWidget extends StatelessWidget {
  final String? hintText;
  final double? heightButton;
  final double? widthButton;
  final FontWeight? fontWeight;
  final Color? backgroundColor;
  final Color? textColor;
  final Function()? onPressed;

  const ButtonWidget(
      { Key? key,
        this.hintText,
        this.heightButton,
        this.widthButton,
        this.fontWeight,
        this.backgroundColor,
        this.textColor,
        this.onPressed,
      }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return SizedBox(
      height: heightButton ?? 6.h,
      width: widthButton ?? 25.w,
      child: ElevatedButton(
        onPressed: onPressed,
        style: ButtonStyle(
          backgroundColor: MaterialStateProperty.all<Color>(
              backgroundColor ?? AppColors().whiteColor,
          ),
          shape: MaterialStateProperty.all<RoundedRectangleBorder>(
            RoundedRectangleBorder(
              borderRadius: BorderRadius.circular(5.h),
            ),
          ),
        ),
        child: TextWidget(
          hintText ?? "",
          textColor: textColor ?? AppColors().whiteColor,
          fontSize: 16.sp,
          fontWeight: fontWeight ?? FontWeight.normal,
        ),
      ),
    );
  }
}