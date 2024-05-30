CREATE TABLE IF NOT EXISTS public."Cliente"
(
    "Id" integer generated always as identity,
    "Nome" character varying(300) COLLATE pg_catalog."default" NOT NULL,
    "Cpf" character varying(14) COLLATE pg_catalog."default" NOT NULL,
    "Cep" character varying(10) COLLATE pg_catalog."default" NOT NULL,
    "Logradouro" character varying(400) COLLATE pg_catalog."default" NOT NULL,
    "Bairro" character varying(300) COLLATE pg_catalog."default" NOT NULL,
    "Cidade" character varying(300) COLLATE pg_catalog."default" NOT NULL,
    "Estado" character varying(2) COLLATE pg_catalog."default" NOT NULL,
    "Numero" character varying(50) COLLATE pg_catalog."default" NOT NULL,
    "Complemento" character varying(500) COLLATE pg_catalog."default",
    "Telefone" character varying(20) COLLATE pg_catalog."default" NOT NULL,
    "Email" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "DataInclusao" timestamp without time zone NOT NULL,
    CONSTRAINT "Cliente_pkey" PRIMARY KEY ("Id"),
    CONSTRAINT "Uni_CPF" UNIQUE ("Cpf")
);

ALTER TABLE IF EXISTS public."Cliente"
    OWNER to postgres;

CREATE TABLE IF NOT EXISTS public."Produto"
(
    "Id" integer generated always as identity,
    "Nome" character varying(200) COLLATE pg_catalog."default" NOT NULL,
    "Codigo" character varying(200) COLLATE pg_catalog."default" NOT NULL,
    "Descricao" character varying(1000) COLLATE pg_catalog."default" NOT NULL,
    "Preco" numeric(14,2) NOT NULL,
    "Quantidade" numeric(14,2) NOT NULL,
    "DataInclusao" timestamp without time zone NOT NULL,
    CONSTRAINT "Produto_pkey" PRIMARY KEY ("Id"),
    CONSTRAINT "Un_Codigo" UNIQUE ("Codigo")
);

ALTER TABLE IF EXISTS public."Produto"
    OWNER to postgres;

CREATE INDEX IF NOT EXISTS "Index_Codigo"
    ON public."Produto" USING btree
    ("Codigo" COLLATE pg_catalog."default" text_pattern_ops ASC NULLS LAST)
    INCLUDE("Codigo")
    WITH (deduplicate_items=False)
    TABLESPACE pg_default;

CREATE TABLE IF NOT EXISTS public."Venda"
(
    "Id" integer generated always as identity,
    "ClienteId" integer NOT NULL,
    "ValorTotal" numeric(14,2) NOT NULL,
    "TipoPagamento" integer NOT NULL,
    "DataInclusao" timestamp without time zone NOT NULL,
    CONSTRAINT "Venda_pkey" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ClienteId_Cliente" FOREIGN KEY ("ClienteId")
        REFERENCES public."Cliente" ("Id") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE RESTRICT
);

ALTER TABLE IF EXISTS public."Venda"
    OWNER to postgres;
	
CREATE TABLE IF NOT EXISTS public."ProdutosXVenda"
(
    "Id" integer generated always as identity,
    "ProdutoId" integer NOT NULL,
    "VendaId" integer NOT NULL,
    "PrecoProduto" numeric(14,2) NOT NULL,
    "QuantidadeProduto" numeric(14,2) NOT NULL,
    "DataInclusao" timestamp without time zone NOT NULL,
    CONSTRAINT "ProdutosXVenda_pkey" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_ProdutoId_Produto" FOREIGN KEY ("ProdutoId")
        REFERENCES public."Produto" ("Id") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE RESTRICT
);

ALTER TABLE IF EXISTS public."ProdutosXVenda"
    OWNER to postgres;
