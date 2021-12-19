import 'package:flutter/material.dart';
import 'package:get/get.dart';

class LoginController extends GetxController {
  late TextEditingController loginInput;
  late TextEditingController passwordInput;
  late RxBool passwordFieldEnabled;

  LoginController(){
    loginInput = TextEditingController();
    passwordInput = TextEditingController();
    passwordFieldEnabled = true.obs;
  }

}