import 'package:flutter/material.dart';
import 'package:get/get.dart';

class LoginController extends GetxController {
  late TextEditingController loginInput;
  late TextEditingController passwordInput;

  LoginController(){
    loginInput = TextEditingController();
    passwordInput = TextEditingController();
  }

}