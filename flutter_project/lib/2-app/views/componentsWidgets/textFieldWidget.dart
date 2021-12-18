import 'package:flutter/material.dart';
import 'package:flutter_project/2-app/views/stylePages/appColors.dart';
import 'package:responsive_sizer/responsive_sizer.dart';

class TextFieldWidget extends StatelessWidget {
  final String? hintText;
  final int? maxLength;
  final bool? ableField;
  final double? height;
  final double? width;
  final double? fontSize;
  final Widget? iconTextField;
  final Color? textColor;
  final Color? borderColor;
  final TextStyle? textStyle;
  final TextAlignVertical? textAlignVertical;
  final FocusNode? focusNode;
  final TextInputType? keyboardType;
  final InputDecoration? decoration;
  final Function()? onTap;
  final Function()? onEditingComplete;
  final Function(String)? onChanged;
  final Function(String)? onSubmitted;
  final TextEditingController controller;

  const TextFieldWidget(
      { Key? key,
        this.hintText,
        this.maxLength,
        this.ableField,
        this.height,
        this.width,
        this.fontSize,
        this.iconTextField,
        this.textColor,
        this.borderColor,
        this.textStyle,
        this.textAlignVertical,
        this.focusNode,
        this.keyboardType,
        this.decoration,
        this.onTap,
        this.onEditingComplete,
        this.onChanged,
        this.onSubmitted,
        required this.controller,
      }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return SizedBox(
      height: height ?? 65,
      width: width ?? 200,
      child: TextField(
        maxLength: maxLength,
        style: textStyle ?? standardTextStyle(),
        textAlignVertical: textAlignVertical ?? TextAlignVertical.center,
        focusNode: focusNode,
        keyboardType: keyboardType ?? TextInputType.text,
        decoration: decoration ?? standardDecoration(),
        enabled: ableField ?? true,
        onTap: onTap,
        onEditingComplete: onEditingComplete,
        onChanged: onChanged,
        onSubmitted: onSubmitted,
        controller: controller,
      ),
    );
  }

  InputDecoration standardDecoration(){
    double heightInput = 65;
    if(height != null)
      heightInput = height!;
    return InputDecoration(
      hintText: hintText,
      hintStyle: TextStyle(
        fontSize: 2.h,
      ),
      suffixIcon: iconTextField,
      border: OutlineInputBorder(
        borderRadius: BorderRadius.circular(10),
        borderSide: BorderSide(
          color: borderColor ?? AppColors().whiteColor,
        ),
      ),
      contentPadding: EdgeInsets.only(
          bottom: heightInput / 2,  // HE
          left: 10// RE THE IMPORTANT PART
      ),
    );
  }

  TextStyle standardTextStyle(){
    return TextStyle(
      color: textColor ?? AppColors().whiteColor,
      fontSize: fontSize ?? 17,
    );
  }
}