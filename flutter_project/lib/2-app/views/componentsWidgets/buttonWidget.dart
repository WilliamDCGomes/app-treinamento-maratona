import 'package:flutter/material.dart';
import 'package:flutter_project/2-app/views/stylePages/appColors.dart';
import 'package:responsive_sizer/responsive_sizer.dart';

import 'textWidget.dart';

class ButtonWidget extends StatelessWidget {
  final String? hintText;
  final Color? backgroundColor;
  final Color? textColor;
  final Function()? onPressed;

  const ButtonWidget(
      { Key? key,
        this.hintText,
        this.backgroundColor,
        this.textColor,
        this.onPressed,
      }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return SizedBox(
      height: 5.5.h,
      width: 25.w,
      child: ElevatedButton(
        onPressed: onPressed,
        style: ButtonStyle(
          backgroundColor: MaterialStateProperty.all<Color>(
              backgroundColor ?? CoresAplicativos().corBranca
          ),
          shape: MaterialStateProperty.all<RoundedRectangleBorder>(
            RoundedRectangleBorder(
              borderRadius: BorderRadius.circular(1.h),
            ),
          ),
        ),
        child: TextWidget(
          hintText ?? "",
          textColor: textColor ?? CoresAplicativos().corBranca,
          fontSize: 2.h,
        ),
      ),
    );
  }
}