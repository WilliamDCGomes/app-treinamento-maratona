import 'dart:ui';
import 'package:flutter/material.dart';

class AppColors {
  static final AppColors _appColors = AppColors._internal();
  factory AppColors() {
    return _appColors;
  }
  AppColors._internal();

  final Color whiteColor = Colors.white;
  final Color blackColor = Colors.black;
  final Color blackColor91Percent = const Color(0XFF919191);
  final Color grayColor = const Color(0XFFE1E1E1);
  final Color brightBlueColor = const Color(0XFF0079D9);
  final Color darkBlueColor = const Color(0XFF004373);
  final Color googleLogoBackgroundColor = const Color(0XFFD34836);
  final Color facebookLogoBackgroundColor = const Color(0XFF3B5998);
}