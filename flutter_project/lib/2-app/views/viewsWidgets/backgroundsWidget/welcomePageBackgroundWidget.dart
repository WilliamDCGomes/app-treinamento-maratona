import 'package:flutter/material.dart';
import 'package:flutter_project/2-app/helpers/paths.dart';
import 'package:flutter_project/2-app/helpers/phoneTablet.dart';
import 'package:responsive_sizer/responsive_sizer.dart';

class WelcomePageBackgroundWidget extends StatelessWidget {
  const WelcomePageBackgroundWidget({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Stack(
      children: [
        Image.asset(
          "${Paths().imagesPath}backgroundWelcomePage.png",
          fit: PhoneTablet().isPhone(context) ? BoxFit.fitHeight : BoxFit.fitHeight,
          height: 100.h,
          width: 100.w,
        ),
        Container(
          height: 100.h,
          width: 100.w,
          color: Color.fromRGBO(0, 0, 0, 0.4),
        ),
      ],
    );
  }
}
