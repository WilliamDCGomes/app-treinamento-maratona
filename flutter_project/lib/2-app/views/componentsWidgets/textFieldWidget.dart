import 'package:flutter/material.dart';
import 'package:responsive_sizer/responsive_sizer.dart';

class TextFieldWidget extends StatelessWidget {
  final String? hintText;
  final int? maxLength;
  final bool? campoHabilitado;
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
        this.campoHabilitado,
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
        style: textStyle ?? textStylePadrao(),
        textAlignVertical: textAlignVertical ?? TextAlignVertical.center,
        focusNode: focusNode,
        keyboardType: keyboardType ?? TextInputType.text,
        decoration: decoration ?? decorationPadrao(),
        enabled: campoHabilitado ?? true,
        onTap: onTap,
        onEditingComplete: onEditingComplete,
        onChanged: onChanged,
        onSubmitted: onSubmitted,
        controller: controller,
      ),
    );
  }

  InputDecoration decorationPadrao(){
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
          color: borderColor ?? const Color(0XFFF0F0F0),
        ),
      ),
      contentPadding: EdgeInsets.only(
          bottom: heightInput / 2,  // HE
          left: 10// RE THE IMPORTANT PART
      ),
    );
  }

  TextStyle textStylePadrao(){
    return TextStyle(
      color: textColor ?? Colors.black,
      fontSize: fontSize ?? 17,
    );
  }
}