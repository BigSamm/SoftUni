<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_e376c751e330419d3f9a1a4b0a70adfbd1d2211ad6355062ee234a1596327f48 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@Twig/layout.html.twig", "@Twig/Exception/exception_full.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'title' => array($this, 'block_title'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@Twig/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_90dd56f26b91f6df4ffefabd935e1777c1428fe1f8bff6123e01e96ddb6a2f9a = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_90dd56f26b91f6df4ffefabd935e1777c1428fe1f8bff6123e01e96ddb6a2f9a->enter($__internal_90dd56f26b91f6df4ffefabd935e1777c1428fe1f8bff6123e01e96ddb6a2f9a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $__internal_fdca8f0e9671dd0be150d5c31064456c536a42efbd7d59b8728aee6474a38294 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_fdca8f0e9671dd0be150d5c31064456c536a42efbd7d59b8728aee6474a38294->enter($__internal_fdca8f0e9671dd0be150d5c31064456c536a42efbd7d59b8728aee6474a38294_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_90dd56f26b91f6df4ffefabd935e1777c1428fe1f8bff6123e01e96ddb6a2f9a->leave($__internal_90dd56f26b91f6df4ffefabd935e1777c1428fe1f8bff6123e01e96ddb6a2f9a_prof);

        
        $__internal_fdca8f0e9671dd0be150d5c31064456c536a42efbd7d59b8728aee6474a38294->leave($__internal_fdca8f0e9671dd0be150d5c31064456c536a42efbd7d59b8728aee6474a38294_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_0bb4332abaec71ce16e34b82e0d5c34007617c094ad18497935574da02936d09 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_0bb4332abaec71ce16e34b82e0d5c34007617c094ad18497935574da02936d09->enter($__internal_0bb4332abaec71ce16e34b82e0d5c34007617c094ad18497935574da02936d09_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_046260a5edae4dc17c2baef327831d34bba3c9e90f4eeae5ef5723e3094a2d04 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_046260a5edae4dc17c2baef327831d34bba3c9e90f4eeae5ef5723e3094a2d04->enter($__internal_046260a5edae4dc17c2baef327831d34bba3c9e90f4eeae5ef5723e3094a2d04_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <style>
        .sf-reset .traces {
            padding-bottom: 14px;
        }
        .sf-reset .traces li {
            font-size: 12px;
            color: #868686;
            padding: 5px 4px;
            list-style-type: decimal;
            margin-left: 20px;
        }
        .sf-reset #logs .traces li.error {
            font-style: normal;
            color: #AA3333;
            background: #f9ecec;
        }
        .sf-reset #logs .traces li.warning {
            font-style: normal;
            background: #ffcc00;
        }
        /* fix for Opera not liking empty <li> */
        .sf-reset .traces li:after {
            content: \"\\00A0\";
        }
        .sf-reset .trace {
            border: 1px solid #D3D3D3;
            padding: 10px;
            overflow: auto;
            margin: 10px 0 20px;
        }
        .sf-reset .block-exception {
            -moz-border-radius: 16px;
            -webkit-border-radius: 16px;
            border-radius: 16px;
            margin-bottom: 20px;
            background-color: #f6f6f6;
            border: 1px solid #dfdfdf;
            padding: 30px 28px;
            word-wrap: break-word;
            overflow: hidden;
        }
        .sf-reset .block-exception div {
            color: #313131;
            font-size: 10px;
        }
        .sf-reset .block-exception-detected .illustration-exception,
        .sf-reset .block-exception-detected .text-exception {
            float: left;
        }
        .sf-reset .block-exception-detected .illustration-exception {
            width: 152px;
        }
        .sf-reset .block-exception-detected .text-exception {
            width: 670px;
            padding: 30px 44px 24px 46px;
            position: relative;
        }
        .sf-reset .text-exception .open-quote,
        .sf-reset .text-exception .close-quote {
            font-family: Arial, Helvetica, sans-serif;
            position: absolute;
            color: #C9C9C9;
            font-size: 8em;
        }
        .sf-reset .open-quote {
            top: 0;
            left: 0;
        }
        .sf-reset .close-quote {
            bottom: -0.5em;
            right: 50px;
        }
        .sf-reset .block-exception p {
            font-family: Arial, Helvetica, sans-serif;
        }
        .sf-reset .block-exception p a,
        .sf-reset .block-exception p a:hover {
            color: #565656;
        }
        .sf-reset .logs h2 {
            float: left;
            width: 654px;
        }
        .sf-reset .error-count, .sf-reset .support {
            float: right;
            width: 170px;
            text-align: right;
        }
        .sf-reset .error-count span {
             display: inline-block;
             background-color: #aacd4e;
             -moz-border-radius: 6px;
             -webkit-border-radius: 6px;
             border-radius: 6px;
             padding: 4px;
             color: white;
             margin-right: 2px;
             font-size: 11px;
             font-weight: bold;
        }

        .sf-reset .support a {
            display: inline-block;
            -moz-border-radius: 6px;
            -webkit-border-radius: 6px;
            border-radius: 6px;
            padding: 4px;
            color: #000000;
            margin-right: 2px;
            font-size: 11px;
            font-weight: bold;
        }

        .sf-reset .toggle {
            vertical-align: middle;
        }
        .sf-reset .linked ul,
        .sf-reset .linked li {
            display: inline;
        }
        .sf-reset #output-content {
            color: #000;
            font-size: 12px;
        }
        .sf-reset #traces-text pre {
            white-space: pre;
            font-size: 12px;
            font-family: monospace;
        }
    </style>
";
        
        $__internal_046260a5edae4dc17c2baef327831d34bba3c9e90f4eeae5ef5723e3094a2d04->leave($__internal_046260a5edae4dc17c2baef327831d34bba3c9e90f4eeae5ef5723e3094a2d04_prof);

        
        $__internal_0bb4332abaec71ce16e34b82e0d5c34007617c094ad18497935574da02936d09->leave($__internal_0bb4332abaec71ce16e34b82e0d5c34007617c094ad18497935574da02936d09_prof);

    }

    // line 136
    public function block_title($context, array $blocks = array())
    {
        $__internal_23fa6c9ff436a4bfe306dc019f89cf335158cb25ebdec900c5055d3ecaab8c76 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_23fa6c9ff436a4bfe306dc019f89cf335158cb25ebdec900c5055d3ecaab8c76->enter($__internal_23fa6c9ff436a4bfe306dc019f89cf335158cb25ebdec900c5055d3ecaab8c76_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_a58ac3db815cba9cc30a24f8e2c1364a84095e03e413d4c3f1aedb5bddc9a9ad = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a58ac3db815cba9cc30a24f8e2c1364a84095e03e413d4c3f1aedb5bddc9a9ad->enter($__internal_a58ac3db815cba9cc30a24f8e2c1364a84095e03e413d4c3f1aedb5bddc9a9ad_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 137
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute(($context["exception"] ?? $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, ($context["status_code"] ?? $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, ($context["status_text"] ?? $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_a58ac3db815cba9cc30a24f8e2c1364a84095e03e413d4c3f1aedb5bddc9a9ad->leave($__internal_a58ac3db815cba9cc30a24f8e2c1364a84095e03e413d4c3f1aedb5bddc9a9ad_prof);

        
        $__internal_23fa6c9ff436a4bfe306dc019f89cf335158cb25ebdec900c5055d3ecaab8c76->leave($__internal_23fa6c9ff436a4bfe306dc019f89cf335158cb25ebdec900c5055d3ecaab8c76_prof);

    }

    // line 140
    public function block_body($context, array $blocks = array())
    {
        $__internal_7438ccf6e2bb83d9abd495bb9c32093422955941afe7796a06a93aac0503e964 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_7438ccf6e2bb83d9abd495bb9c32093422955941afe7796a06a93aac0503e964->enter($__internal_7438ccf6e2bb83d9abd495bb9c32093422955941afe7796a06a93aac0503e964_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_9d5de2e5bae6e8992deaa41562bd32420d7b3af9036a647fe55ac0d8dc20fe59 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9d5de2e5bae6e8992deaa41562bd32420d7b3af9036a647fe55ac0d8dc20fe59->enter($__internal_9d5de2e5bae6e8992deaa41562bd32420d7b3af9036a647fe55ac0d8dc20fe59_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 141
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 141)->display($context);
        
        $__internal_9d5de2e5bae6e8992deaa41562bd32420d7b3af9036a647fe55ac0d8dc20fe59->leave($__internal_9d5de2e5bae6e8992deaa41562bd32420d7b3af9036a647fe55ac0d8dc20fe59_prof);

        
        $__internal_7438ccf6e2bb83d9abd495bb9c32093422955941afe7796a06a93aac0503e964->leave($__internal_7438ccf6e2bb83d9abd495bb9c32093422955941afe7796a06a93aac0503e964_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/Exception/exception_full.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  226 => 141,  217 => 140,  200 => 137,  191 => 136,  51 => 4,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@Twig/layout.html.twig' %}

{% block head %}
    <style>
        .sf-reset .traces {
            padding-bottom: 14px;
        }
        .sf-reset .traces li {
            font-size: 12px;
            color: #868686;
            padding: 5px 4px;
            list-style-type: decimal;
            margin-left: 20px;
        }
        .sf-reset #logs .traces li.error {
            font-style: normal;
            color: #AA3333;
            background: #f9ecec;
        }
        .sf-reset #logs .traces li.warning {
            font-style: normal;
            background: #ffcc00;
        }
        /* fix for Opera not liking empty <li> */
        .sf-reset .traces li:after {
            content: \"\\00A0\";
        }
        .sf-reset .trace {
            border: 1px solid #D3D3D3;
            padding: 10px;
            overflow: auto;
            margin: 10px 0 20px;
        }
        .sf-reset .block-exception {
            -moz-border-radius: 16px;
            -webkit-border-radius: 16px;
            border-radius: 16px;
            margin-bottom: 20px;
            background-color: #f6f6f6;
            border: 1px solid #dfdfdf;
            padding: 30px 28px;
            word-wrap: break-word;
            overflow: hidden;
        }
        .sf-reset .block-exception div {
            color: #313131;
            font-size: 10px;
        }
        .sf-reset .block-exception-detected .illustration-exception,
        .sf-reset .block-exception-detected .text-exception {
            float: left;
        }
        .sf-reset .block-exception-detected .illustration-exception {
            width: 152px;
        }
        .sf-reset .block-exception-detected .text-exception {
            width: 670px;
            padding: 30px 44px 24px 46px;
            position: relative;
        }
        .sf-reset .text-exception .open-quote,
        .sf-reset .text-exception .close-quote {
            font-family: Arial, Helvetica, sans-serif;
            position: absolute;
            color: #C9C9C9;
            font-size: 8em;
        }
        .sf-reset .open-quote {
            top: 0;
            left: 0;
        }
        .sf-reset .close-quote {
            bottom: -0.5em;
            right: 50px;
        }
        .sf-reset .block-exception p {
            font-family: Arial, Helvetica, sans-serif;
        }
        .sf-reset .block-exception p a,
        .sf-reset .block-exception p a:hover {
            color: #565656;
        }
        .sf-reset .logs h2 {
            float: left;
            width: 654px;
        }
        .sf-reset .error-count, .sf-reset .support {
            float: right;
            width: 170px;
            text-align: right;
        }
        .sf-reset .error-count span {
             display: inline-block;
             background-color: #aacd4e;
             -moz-border-radius: 6px;
             -webkit-border-radius: 6px;
             border-radius: 6px;
             padding: 4px;
             color: white;
             margin-right: 2px;
             font-size: 11px;
             font-weight: bold;
        }

        .sf-reset .support a {
            display: inline-block;
            -moz-border-radius: 6px;
            -webkit-border-radius: 6px;
            border-radius: 6px;
            padding: 4px;
            color: #000000;
            margin-right: 2px;
            font-size: 11px;
            font-weight: bold;
        }

        .sf-reset .toggle {
            vertical-align: middle;
        }
        .sf-reset .linked ul,
        .sf-reset .linked li {
            display: inline;
        }
        .sf-reset #output-content {
            color: #000;
            font-size: 12px;
        }
        .sf-reset #traces-text pre {
            white-space: pre;
            font-size: 12px;
            font-family: monospace;
        }
    </style>
{% endblock %}

{% block title %}
    {{ exception.message }} ({{ status_code }} {{ status_text }})
{% endblock %}

{% block body %}
    {% include '@Twig/Exception/exception.html.twig' %}
{% endblock %}
", "@Twig/Exception/exception_full.html.twig", "D:\\PHP Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\TwigBundle\\Resources\\views\\Exception\\exception_full.html.twig");
    }
}
