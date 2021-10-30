import 'dart:ui';
import 'package:flutter/material.dart';

class CoresAplicativos {
  static final CoresAplicativos _coresAplicativos = CoresAplicativos._internal();
  factory CoresAplicativos() {
    return _coresAplicativos;
  }
  CoresAplicativos._internal();

  final Color corBranca = Colors.white;
  final Color corPreta = Colors.black;
  final Color corPreto91 = const Color(0XFF919191);
  final Color corCinzaBorda = const Color(0XFFE1E1E1);
}