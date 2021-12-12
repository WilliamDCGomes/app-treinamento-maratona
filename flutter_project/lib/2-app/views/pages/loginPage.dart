import 'package:flutter/material.dart';
import 'package:flutter_project/2-app/helpers/paths.dart';
import 'package:flutter_project/2-app/views/stylePages/appColors.dart';

class LoginPage extends StatefulWidget {
  const LoginPage({Key? key}) : super(key: key);

  @override
  _LoginPageState createState() => _LoginPageState();
}

class _LoginPageState extends State<LoginPage> {
  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: Material(
        child: Scaffold(
          backgroundColor: AppColors().backgroundStandardColor,
          appBar: AppBar(
            title: Text(
              "Login",
              style: TextStyle(
                color: AppColors().whiteColor,
              ),
            ),
            backgroundColor: AppColors().backgroundStandardColor,
          ),
          body: Column(
            children: [
              Image.asset("${Paths().imagesPath}oie_transparent.png"),
            ],
          ),
        ),
      ),
    );
  }
}
