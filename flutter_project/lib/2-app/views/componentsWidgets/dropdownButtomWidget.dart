import 'package:flutter/material.dart';
import 'package:flutter_project/2-app/views/stylePages/appColors.dart';
import 'package:responsive_sizer/responsive_sizer.dart';

import 'textWidget.dart';

class DropdownButtonWidget extends StatelessWidget {
  final List<String> itensLista;
  final String? itemSelecionado;
  final String? hintText;
  final Function(String?)? onChanged;

  const DropdownButtonWidget(
      { Key? key,
        required this.itensLista,
        this.itemSelecionado,
        this.hintText,
        required this.onChanged,
      }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      height: 5.5.h,
      width: 20.w,
      decoration: BoxDecoration(
        borderRadius: BorderRadius.circular(10),
        border: Border.all(
          color: CoresAplicativos().corCinzaBorda,
        ),
      ),
      child: Padding(
        padding: const EdgeInsets.all(10),
        child: DropdownButtonHideUnderline(
          child:DropdownButton(
            items: itensLista.map((String item) {
              return DropdownMenuItem<String>(
                child: Text(item),
                value: item,
              );
            }).toList(),
            value: itemSelecionado,
            onChanged: onChanged,
            hint:TextWidget(
              hintText ?? "",
              fontSize: 2.h,
            ),
            elevation: 8,
            style:TextStyle(
              color:CoresAplicativos().corPreto91,
              fontSize: 16,
            ),
            icon: RotationTransition(
              turns: AlwaysStoppedAnimation(3 / 4),
              child: Icon(
                Icons.arrow_back_ios_outlined,
                color: CoresAplicativos().corPreto91,
                size: 2.5.h,
              ),
            ),
            dropdownColor: CoresAplicativos().corBranca,
          ),
        ),
      ),
    );
  }
}