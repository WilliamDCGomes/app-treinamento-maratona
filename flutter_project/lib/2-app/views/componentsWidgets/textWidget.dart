import 'dart:io';
import 'package:flutter/material.dart';

class TextWidget extends StatelessWidget {
  final String _texto;
  final Color? textColor;
  final TextAlign? textAlign;
  final double? fontSize;
  final FontWeight? fontWeight;
  final TextDecoration? textDecoration;

  TextWidget(
      this._texto,
      {
        Key? key,
        this.textColor,
        this.textAlign,
        this.fontSize,
        this.fontWeight,
        this.textDecoration,
      }
      ) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Text(
      _texto,
      style: TextStyle(
        color: textColor,
        fontSize: fontSize ?? (Platform.isAndroid ? 20 : 35),
        fontWeight: fontWeight ?? FontWeight.normal,
        decoration: textDecoration,
      ),
      textAlign: textAlign ?? TextAlign.center,
    );
  }
}