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
        $__internal_1ac9b062f8be1f59d52acd0c7e16e1cbd7fc65d8afe2ee38588e1ff63457f91f = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_1ac9b062f8be1f59d52acd0c7e16e1cbd7fc65d8afe2ee38588e1ff63457f91f->enter($__internal_1ac9b062f8be1f59d52acd0c7e16e1cbd7fc65d8afe2ee38588e1ff63457f91f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $__internal_e57cf37823eaf7ff8c1348fe6c696f74e6d883e4a269eb6bf5d3a4ca4ed1b5e8 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e57cf37823eaf7ff8c1348fe6c696f74e6d883e4a269eb6bf5d3a4ca4ed1b5e8->enter($__internal_e57cf37823eaf7ff8c1348fe6c696f74e6d883e4a269eb6bf5d3a4ca4ed1b5e8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_1ac9b062f8be1f59d52acd0c7e16e1cbd7fc65d8afe2ee38588e1ff63457f91f->leave($__internal_1ac9b062f8be1f59d52acd0c7e16e1cbd7fc65d8afe2ee38588e1ff63457f91f_prof);

        
        $__internal_e57cf37823eaf7ff8c1348fe6c696f74e6d883e4a269eb6bf5d3a4ca4ed1b5e8->leave($__internal_e57cf37823eaf7ff8c1348fe6c696f74e6d883e4a269eb6bf5d3a4ca4ed1b5e8_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_41670e27d271066d00fd531c24ba61401f5ae7f4389007740e82b04704fc775c = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_41670e27d271066d00fd531c24ba61401f5ae7f4389007740e82b04704fc775c->enter($__internal_41670e27d271066d00fd531c24ba61401f5ae7f4389007740e82b04704fc775c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_545eed895edbec936042a686eeb263e9989fc728742a42e39a51a4bcb8870694 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_545eed895edbec936042a686eeb263e9989fc728742a42e39a51a4bcb8870694->enter($__internal_545eed895edbec936042a686eeb263e9989fc728742a42e39a51a4bcb8870694_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

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
        
        $__internal_545eed895edbec936042a686eeb263e9989fc728742a42e39a51a4bcb8870694->leave($__internal_545eed895edbec936042a686eeb263e9989fc728742a42e39a51a4bcb8870694_prof);

        
        $__internal_41670e27d271066d00fd531c24ba61401f5ae7f4389007740e82b04704fc775c->leave($__internal_41670e27d271066d00fd531c24ba61401f5ae7f4389007740e82b04704fc775c_prof);

    }

    // line 136
    public function block_title($context, array $blocks = array())
    {
        $__internal_6b057668c9f89eb881dd36a391b57d95229a0494f18a829bf0e821c656f396c5 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_6b057668c9f89eb881dd36a391b57d95229a0494f18a829bf0e821c656f396c5->enter($__internal_6b057668c9f89eb881dd36a391b57d95229a0494f18a829bf0e821c656f396c5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_d3f692ac1186f8fb728ad4b7f36cfbd59d801a0a933cfa0e97020b1c86981101 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d3f692ac1186f8fb728ad4b7f36cfbd59d801a0a933cfa0e97020b1c86981101->enter($__internal_d3f692ac1186f8fb728ad4b7f36cfbd59d801a0a933cfa0e97020b1c86981101_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 137
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute(($context["exception"] ?? $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, ($context["status_code"] ?? $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, ($context["status_text"] ?? $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_d3f692ac1186f8fb728ad4b7f36cfbd59d801a0a933cfa0e97020b1c86981101->leave($__internal_d3f692ac1186f8fb728ad4b7f36cfbd59d801a0a933cfa0e97020b1c86981101_prof);

        
        $__internal_6b057668c9f89eb881dd36a391b57d95229a0494f18a829bf0e821c656f396c5->leave($__internal_6b057668c9f89eb881dd36a391b57d95229a0494f18a829bf0e821c656f396c5_prof);

    }

    // line 140
    public function block_body($context, array $blocks = array())
    {
        $__internal_227b30d4193bc51c0692d650aa243c754de5dcd087b6d3c9b57d9c1759f9e0e7 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_227b30d4193bc51c0692d650aa243c754de5dcd087b6d3c9b57d9c1759f9e0e7->enter($__internal_227b30d4193bc51c0692d650aa243c754de5dcd087b6d3c9b57d9c1759f9e0e7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_f26ead719aa5804e445ac02f6d0cf66b86369d4f9e7f5c4fb777bba290dd67e8 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f26ead719aa5804e445ac02f6d0cf66b86369d4f9e7f5c4fb777bba290dd67e8->enter($__internal_f26ead719aa5804e445ac02f6d0cf66b86369d4f9e7f5c4fb777bba290dd67e8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 141
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 141)->display($context);
        
        $__internal_f26ead719aa5804e445ac02f6d0cf66b86369d4f9e7f5c4fb777bba290dd67e8->leave($__internal_f26ead719aa5804e445ac02f6d0cf66b86369d4f9e7f5c4fb777bba290dd67e8_prof);

        
        $__internal_227b30d4193bc51c0692d650aa243c754de5dcd087b6d3c9b57d9c1759f9e0e7->leave($__internal_227b30d4193bc51c0692d650aa243c754de5dcd087b6d3c9b57d9c1759f9e0e7_prof);

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
", "@Twig/Exception/exception_full.html.twig", "D:\\PHP Solution\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\TwigBundle\\Resources\\views\\Exception\\exception_full.html.twig");
    }
}
