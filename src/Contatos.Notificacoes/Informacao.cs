﻿using Contatos.Notificacoes.Base;
using Contatos.Notificacoes.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contatos.Notificacoes
{
    public class Informacao : Notificacao
    {
        public Informacao(CriticidadeEnum criticidade,
            string propriedade, string mensagem, CamadaEnum? camada, TipoNotificacaoEnum? tipoNotificacaoEnum)
            : base(criticidade, propriedade, mensagem, camada, tipoNotificacaoEnum)
        {
        }
    }
}
